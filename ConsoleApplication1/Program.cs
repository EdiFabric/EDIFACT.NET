using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EdiFabric.Framework.Readers;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<long> times = new List<long>();

            for (var i = 0; i < 5; i++)
            {
                var edi = Assembly.GetExecutingAssembly().GetManifestResourceStream("ConsoleApplication1.Edi.Hipaa_837P_00501_HL.txt");
                var watch = System.Diagnostics.Stopwatch.StartNew();
                using (var ediReader = new X12Reader(edi, "EdiFabric.Rules.Hipaa005010"))
                //using (var ediReader = X12Reader.Create(edi, "EdiFabric.Rules"))
                {
                    while (ediReader.Read())
                    {
                        var b = ediReader.Item;
                    }
                }
                watch.Stop();
                times.Add(watch.ElapsedMilliseconds);
            }

           long sum = 0;
           foreach(var time in times)
           {
               sum = sum + time;
           }

            var final = sum / times.Count;
        }
    }
}
