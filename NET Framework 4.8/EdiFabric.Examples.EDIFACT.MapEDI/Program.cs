using EdiFabric.Examples.EDIFACT.Common;
using System;

namespace EdiFabric.Examples.EDIFACT.MapEDI
{
    class Program
    {
        static void Main(string[] args)
        {
            License.SetSerial(Config.TrialSerialKey);

            //  Map using XSLT
            EDIToCustomObjectWithXslt.Run();

            //  Map using AutoMapper
            EDIToCustomObjectWithAutoMapper.Run();
        }
    }
}
