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
        public string Id { get; set; }

        public SAttribute(string id, int pos) : base(pos)
        {
            Id = id;
        }        
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
        public string Code { get; set; }
        public Type DataType { get; set; }

        public DAttribute(int pos, Type dataType = null, string code = null) : base(pos)
        {
            Code = code;
            DataType = dataType;
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class AAttribute : EdiAttribute
    {
        public AAttribute(int pos) : base(pos)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class MAttribute : Attribute
    {
        public string Format { get; set; }
        public string Version { get; set; }
        public string Id { get; set; }

        public MAttribute(string format, string version, string id)
        {
            Format = format;
            Version = version;
            Id = id;
        }       
    }
}
