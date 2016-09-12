namespace EdiFabric.Framework
{
    public class EdiMessage
    {
        public string InterchangeHeader { get; private set; }
        public string GroupHeader { get; private set; }
        public object Value { get; private set; }

        public EdiMessage(object value, string interchangeHeader, string groupHeader)
        {
            InterchangeHeader = interchangeHeader;
            GroupHeader = groupHeader;
            Value = value;
        }
    }
}
