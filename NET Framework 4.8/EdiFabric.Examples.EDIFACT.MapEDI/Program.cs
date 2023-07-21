using EdiFabric.Examples.EDIFACT.Common;

namespace EdiFabric.Examples.EDIFACT.MapEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenFileCache.Set();

            //  Map using XSLT
            EDIToCustomObjectWithXslt.Run();

            //  Map using AutoMapper
            EDIToCustomObjectWithAutoMapper.Run();
        }
    }
}
