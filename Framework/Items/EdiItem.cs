namespace EdiFabric.Framework.Items
{
    /// <summary>
    /// Abstract EDI item
    /// </summary>
    public abstract class EdiItem
    {
        /// <summary>
        /// The value of the item.
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiItem"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        protected EdiItem(object value)
        {
            Value = value;
        }
    }
}
