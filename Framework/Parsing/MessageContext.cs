using System;
using System.Configuration;
using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Parsing
{
    class MessageContext
    {
        public string Tag { get; private set; }
        public string ControlNumber { get; private set; }
        public string Version { get; private set; }
        public string Format { get; private set; }
        public string RulesAssemblyName { get; private set; }
        public string RulesNamespacePrefix { get; private set; }
        public Type Type { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContext"/> class.
        /// </summary>
        public MessageContext(string tag, string controlNumber, string version, string format, string assemblyName,
            string prefix)
        {
            Tag = tag;
            ControlNumber = controlNumber;
            Version = version;
            Format = format;
            try
            {
                RulesAssemblyName = assemblyName ?? ConfigurationManager.AppSettings["EdiFabric.RulesAssemblyName"];
            }
            catch (Exception)
            {
                throw new ParsingException(ErrorCodes.RulesAssemblyNameNotSet,
                     "The name of the rules assembly was neither set in .config nor passed explicitly.");
            }
            
            RulesNamespacePrefix = prefix ?? "EdiFabric.Rules";
            Type = ToType();
        }

        private Type ToType()
        {
            var typeFullName = RulesNamespacePrefix.TrimEnd('.') + "." + Format + Version + Tag;
            typeFullName = typeFullName + ".M_" + Tag;
            var errorMsg = String.Format(
                            "Type '{0}' was not found in assembly '{1}'.",
                            typeFullName, RulesAssemblyName);
            try
            {
                var systemType = Type.GetType(typeFullName + ", " + RulesAssemblyName);
                if (systemType == null)
                    throw new ParsingException(ErrorCodes.UnexpectedMessage, errorMsg);

                return systemType;
            }
            catch (Exception)
            {
                throw new ParsingException(ErrorCodes.UnexpectedMessage, errorMsg);
            }
        }
    }   
}
