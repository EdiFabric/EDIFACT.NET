using EdiFabric.Framework.Headers;
using EdiFabric.Framework.Readers;

namespace EdiFabric.Framework.Items
{
    /// <summary>
    /// EDI audit for listing the headers.
    /// </summary>
    public class EdiControl<T> : EdiItem where T : IEdiControl
    {
        /// <summary>
        /// The separators.
        /// </summary>
        public Separators Separators { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiControl{T}"/> class.
        /// </summary>
        /// <param name="controlSegment">The control line.</param> 
        /// <param name="separators">The separators.</param>        
        public EdiControl(string controlSegment, Separators separators)
            : base(controlSegment)
        {
            Separators = separators;
        }

        /// <summary>
        /// Parses the segment string to an instance.
        /// </summary>
        /// <returns>The segment as .NET object.</returns>
        public T Parse()
        {
            return ((string)Value).ParseSegment<T>(Separators);
        }
    }
}
