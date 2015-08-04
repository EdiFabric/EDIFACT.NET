using System.Collections.Generic;
using System.Xml.Linq;

namespace EdiFabric.Framework.Envelopes
{
    public abstract class AbstractInterchange
    {
        /// <summary>
        /// Converts the interchange to edi message.
        /// </summary>
        /// <param name="context">
        /// The interchange context.
        /// This sets the non format default separators.
        /// </param>
        /// <returns>
        /// The edi message.
        /// </returns>
        public abstract List<string> ToEdi(InterchangeContext context = null);

        /// <summary>
        /// Serialize the interchange into xml
        /// </summary>
        /// <returns>
        /// The serialized xml.
        /// </returns>
        public XElement Serialize()
        {
            return EdiHelper.Serialize(this);
        }
    }
}
