using System;
using System.Linq;
using System.Reflection;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Parsing
{
    public class MessageContext
    {
        public string Tag { get; private set; }
        public string ControlNumber { get; private set; }
        public string Version { get; private set; }
        public string Format { get; private set; }
        public Type SystemType { get; private set; }
        public string XsdName
        {
            get
            {
                return "EF_" + Format + "_" + Version + "_" + Tag + ".xsd";
            }            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        public MessageContext(string tag, string controlNumber, string version, string format,
            Func<MessageContext, Assembly> rulesAssembly, Func<MessageContext, string> rulesNamespacePrefix)
        {
            Tag = tag;
            ControlNumber = controlNumber;
            Version = version;
            Format = format;
            SystemType = ToSystemType(rulesAssembly, rulesNamespacePrefix);
        }

        public MessageContext(object message)
        {
            var typeName = message.GetType().FullName;
            var parts = typeName.Split('.');

            if (parts.Length < 2)
                throw new Exception(string.Format("Unable to determine XSD from {0}.", typeName));

            var version = parts[parts.Length - 2];
            var tag = parts.Last().Replace("M_", "");
            if (version.StartsWith("X12", StringComparison.Ordinal))
            {
                version = version.Replace("X12", "");
                Format = "X12";
            }
            else if (version.StartsWith("Edifact", StringComparison.Ordinal))
            {
                version = version.Replace("Edifact", "");
                Format = "EDIFACT";
            }
            else
                throw new Exception(string.Format("Unable to determine XSD from {0}.", typeName));

            Tag = tag;
            Version = version.Replace(tag, "");
            SystemType = message.GetType();
        }

        private Type ToSystemType(Func<MessageContext, Assembly> rulesAssembly, Func<MessageContext, string> rulesNamespacePrefix)
        {
            var assembly = rulesAssembly(this);
            var ns = rulesNamespacePrefix(this);
            var typeFullName = ns.TrimEnd('.') + "." + Format + Version + Tag + ".M_" + Tag;
            var errorMsg = String.Format(
                            "Type '{0}' was not found in assembly '{1}'.",
                            typeFullName, assembly.FullName);
            try
            {
                var systemType = Type.GetType(typeFullName + ", " + assembly.FullName);
                if (systemType == null)
                    throw new ParsingException(ErrorCodes.InvalidInterchangeContent, errorMsg, null,
                        new MessageErrorContext(Tag, ControlNumber, ErrorCodes.UnexpectedMessage));

                return systemType;
            }
            catch (Exception)
            {
                throw new ParsingException(ErrorCodes.UnexpectedMessage, errorMsg);
            }
        }
    }   
}
