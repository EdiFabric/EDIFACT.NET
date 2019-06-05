using AutoMapper;
using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiFabric.Examples.EDIFACT.MapEDI
{
    class EDIToCustomObjectWithAutoMapper
    {
        public static void Run()
        {
            Debug.WriteLine("******************************");
            Debug.WriteLine(MethodBase.GetCurrentMethod().Name);
            Debug.WriteLine("******************************");

            //  Init the AutoMapper map
            //  Map by interface to reuse mapping 
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<TSORDERS, PurchaseOrder>();                  

                    cfg.CreateMap<I_NAD<C082, C058, C080, C059>, Customer>()
                        .ForMember(dest => dest.RefNumber, m => m.MapFrom(src => src.PARTYIDENTIFICATIONDETAILS_02.Partyididentification_01))
                        .ForMember(dest => dest.Name, m => m.MapFrom(src => src.PARTYNAME_04.Partyname_01))
                        .ForMember(dest => dest.AddressLine, m => m.MapFrom(src => src.STREET_05.Streetandnumberpobox_01))
                        .ForMember(dest => dest.City, m => m.MapFrom(src => src.Cityname_06))
                        .ForMember(dest => dest.State, m => m.MapFrom(src => src.Countrysubentityidentification_07))
                        .ForMember(dest => dest.PostCode, m => m.MapFrom(src => src.Postcodeidentification_08));

                    cfg.CreateMap<I_BGM<C002>, PurchaseOrder>()
                        .ForPath(dest => dest.RefNumber, m => m.MapFrom(src => src.Documentmessagenumber_02));

                    cfg.CreateMap<I_DTM<C507>, PurchaseOrder>()
                        .ForPath(dest => dest.Date, m => m.MapFrom(src => src.DATETIMEPERIOD_01.Datetimeperiod_02.Substring(0, 4) + "-" + src.DATETIMEPERIOD_01.Datetimeperiod_02.Substring(4, 2) + "-" + src.DATETIMEPERIOD_01.Datetimeperiod_02.Substring(6, 2)));

                    cfg.CreateMap<I_LIN<C212, C829>, OrderLine>()
                        .ForMember(dest => dest.LineNumber, m => m.MapFrom(src => src.Lineitemnumber_01))
                        .ForMember(dest => dest.UPCNumber, m => m.MapFrom(src => src.ITEMNUMBERIDENTIFICATION_03.Itemnumber_01));

                    cfg.CreateMap<I_QTY<C186>, OrderLine>()
                        .ForMember(dest => dest.Quantity, m => m.MapFrom(src => src.QUANTITYDETAILS_01.Quantity_02))
                        .ForMember(dest => dest.UOM, m => m.MapFrom(src => src.QUANTITYDETAILS_01.Measureunitqualifier_03));

                    cfg.CreateMap<I_PRI<C509>, OrderLine>()
                        .ForMember(dest => dest.Price, m => m.MapFrom(src => src.PRICEINFORMATION_01.Price_02));
                }
            );

            var ediStream = File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Files\Edifact\PurchaseOrderCSV.txt");

            List<IEdiItem> ediItems;
            using (var ediReader = new EdifactReader(ediStream, "EdiFabric.Examples.EDIFACT.Templates.D96A.NoValidation"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var transactions = ediItems.OfType<TSORDERS>();
            foreach (var transaction in transactions)
            {
                //  Transform each transaction
                PurchaseOrder customTransaction = Mapper.Map<TSORDERS, PurchaseOrder>(transaction);

                customTransaction = Mapper.Map<I_BGM<C002>, PurchaseOrder>(transaction.BGM, customTransaction);
                customTransaction = Mapper.Map<I_DTM<C507>, PurchaseOrder>(transaction.DTM.Single(dtm => dtm.DATETIMEPERIOD_01.Datetimeperiodqualifier_01 == "137"), customTransaction);
                customTransaction.Customer = Mapper.Map<I_NAD<C082, C058, C080, C059>, Customer>(transaction.NADLoop.Where(nad => nad.NAD.Partyqualifier_01 == "BY").Single().NAD, customTransaction.Customer);
                customTransaction.OrderLines = new List<OrderLine>();
                foreach (var linLoop in transaction.LINLoop)
                {
                    var currentLine = new OrderLine();
                    customTransaction.OrderLines.Add(currentLine);

                    var qty = linLoop.QTY.Single(q => q.QUANTITYDETAILS_01.Quantityqualifier_01 == "21");
                    currentLine = Mapper.Map<I_QTY<C186>, OrderLine>(qty, currentLine);

                    currentLine = Mapper.Map<I_LIN<C212, C829>, OrderLine>(linLoop.LIN, currentLine);

                    var priLoop = linLoop.PRILoop.Single(p => p.PRI.PRICEINFORMATION_01.Pricequalifier_01 == "AAA");
                    currentLine = Mapper.Map<I_PRI<C509>, OrderLine>(priLoop.PRI, currentLine);
                }
            }
        }
    }
}
