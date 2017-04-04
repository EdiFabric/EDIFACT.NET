using System;

namespace EdiFabric.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class EdiAttribute : Attribute
    {
        public int Pos { get; set; }
        public EdiAttribute(int pos)
        {
            Pos = pos;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class SAttribute : EdiAttribute
    {
        public SAttribute(string id, int pos) : base(pos)
        {
            Id = id;
        }

        public string Id { get; set; }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class GAttribute : EdiAttribute
    {
        public GAttribute(int pos) : base(pos)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class CAttribute : EdiAttribute
    {
        public CAttribute(int pos) : base(pos)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class DAttribute : EdiAttribute
    {
        public DAttribute(int pos) : base(pos)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class MAttribute : Attribute
    {
        public MAttribute(string format, string version, string id)
        {
            Format = format;
            Version = version;
            Id = id;
        }

        public string Format { get; set; }
        public string Version { get; set; }
        public string Id { get; set; }
    }
}
