using System.Text;

namespace EdiFabric.Framework.Readers
{
    /// <summary>
    /// The additional settings for the reader.
    /// </summary>
    public class ReaderSettings
    {
        /// <summary>
        /// The encoding. The default is Encoding.Default.
        /// </summary>
        public Encoding Encoding;
        /// <summary>
        /// The full assembly name of the assembly containing the EDI classes. The default is Edifabric.Rules.
        /// </summary>
        public string RulesAssemblyName;
        /// <summary>
        /// The namespace prefix for the EDI classes. The default is Edifabric.Rules.
        /// </summary>
        public string RulesNamespacePrefix;
    }
}
