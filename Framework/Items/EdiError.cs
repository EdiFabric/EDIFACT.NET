using EdiFabric.Framework.Exceptions;

namespace EdiFabric.Framework.Items
{
    /// <summary>
    /// EDI error with custom error code.
    /// </summary>
    public class EdiError : EdiItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdiError"/> class.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public EdiError(ParsingException exception)
            : base(exception)
        {
        }
    }
}
