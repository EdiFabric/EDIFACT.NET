namespace EdiFabric.Framework.Exceptions
{
    public class ParsingDetails
    {
        public bool MessageDefined = true;
        public string SegmentName { get; set; }
        public int SegmentPosition { get; set; }
        public bool SegmentDefined { get; set; }
        public string SegmentValue { get; set; }
        public string DataElementName { get; set; }
        public int DataElementPosition { get; set; }
        public int ComponentDataElementPosition { get; set; }
        public int RepetitionDataElementPosition { get; set; }
        public string DataElementValue { get; set; }
    }
}
