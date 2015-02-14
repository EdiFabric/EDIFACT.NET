//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------
namespace EdiFabric.SampleApplication
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    using EdiFabric.Definitions.X12_004010_214;

    class X12_4010_214
    {
         public M_214 m214 = new M_214();
 
         public X12_4010_214(int ControlNo, string ReferenceID, string ShipmentID, string SCAC )
         {
             this.m214.S_ST = new S_ST();
             this.m214.S_SE = new S_SE();
             this.m214.S_ST.D_143_1 = "214";
           //  m214.S_ST.D_1705_3="2";
             this.m214.S_ST.D_329_2 = "3";

             this.m214.S_B10 = new S_B10();

             this.ReferenceID = ReferenceID;
             this.ShipmentID = ShipmentID;
             this.ControlNumber = ControlNo;
             this.SCAC = SCAC; //S_B10.D_140_3
             this.SegmentCount = 3; //ST /SE /B3
         }

         public string ReferenceID
         {
             get { return this.m214.S_B10.D_127_1; }
             set { this.m214.S_B10.D_127_1 = value; }
         }

         public string ShipmentID
         {
             get { return this.m214.S_B10.D_145_2; }
             set { this.m214.S_B10.D_145_2 = value; }
         }

         public string SCAC
         {
             get { return this.m214.S_B10.D_140_3; }
             set { this.m214.S_B10.D_140_3 = value; }
         }


         public void Add_L11_Reference(string ReferenceID, string ReferenceQualifier, string Description="")
         {

             if (this.m214.S_L11  == null)
             {
                 this.m214.S_L11 = new List<S_L11>();

             }
             this.SegmentCount++;
             S_L11 S_L11 = new S_L11();
             S_L11.D_127_1 = ReferenceID;
             S_L11.D_128_2 = ReferenceQualifier;
             S_L11.D_352_3 = Description;
             this.m214.S_L11.Add(S_L11);
         }



         public G_N1 Add_N1_Name(string EntityIdCode, string Name, string IDCodeQualifier = "", string IDCode="")
         {
             if (this.m214.G_N1 == null)
             {
                 this.m214.G_N1 = new List<G_N1>();
             }
             this.SegmentCount++;
             G_N1 G_N1;

             G_N1 = new G_N1();
             G_N1.S_N1 = new S_N1();
             G_N1.S_N1.D_98_1 = EntityIdCode; 
             if (Name.Length != 0)
                G_N1.S_N1.D_93_2 = Name;

             if (Name.Length != 0)
                 G_N1.S_N1.D_66_3 = IDCodeQualifier;
             if (Name.Length != 0)
                 G_N1.S_N1.D_67_4 = IDCode; 

             this.m214.G_N1.Add(G_N1);
             return G_N1;
         }

         public void Add_N3_Address(G_N1 g_n1, string Address1, string Address2 ="")
         {
             if (g_n1.S_N3 == null)
             {
                 g_n1.S_N3 = new List<S_N3>();
             }
             this.SegmentCount++;
             S_N3 S_N3 = new S_N3();
             S_N3.D_166_1 = Address1;
             if (!string.IsNullOrWhiteSpace(Address2))
                S_N3.D_166_2 = Address2; 
             g_n1.S_N3.Add(S_N3);
         }


         public void Add_N4_Geographic(G_N1 g_n1, string City, string State, string Zip, string Country, string LocationQualifier, string LocationIdentifier)
         {
             this.SegmentCount++;
             g_n1.S_N4 = new S_N4();
             g_n1.S_N4.D_19_1 = City;
             g_n1.S_N4.D_156_2 = State;
             g_n1.S_N4.D_116_3 = Zip;

             g_n1.S_N4.D_26_4  = Country;
             g_n1.S_N4.D_309_5 = LocationQualifier;
             g_n1.S_N4.D_310_6 = LocationIdentifier; 
         }

         public void Add_G62_Date(G_N1 g_n1, string DateType, string Date, string Time="", string TimeType="", string TimeCode="")
         {
             this.SegmentCount++;
             g_n1.S_G62  = new S_G62();
             g_n1.S_G62.D_432_1 = DateType;
             g_n1.S_G62.D_373_2 = Date; //CCYYMMDD
             g_n1.S_G62.D_176_3 = TimeType;
             g_n1.S_G62.D_337_4 = Time;
             g_n1.S_G62.D_623_5 = TimeCode;
         }

         public S_MS3 Add_MS3_Interline_Info(string SCAC, string RoutingSequenceCode,  string CityName="",  string TransportationType="", string StateCode="")
         {
             if (this.m214.S_MS3 == null)
             {
                 this.m214.S_MS3 = new List<S_MS3>();
             }
             this.SegmentCount++;
             S_MS3 s_ms3 = new S_MS3();
             s_ms3.D_140_1 = SCAC;
             s_ms3.D_133_2 = RoutingSequenceCode;
             s_ms3.D_19_3 = CityName;
             s_ms3.D_91_4 = TransportationType;
             s_ms3.D_156_5 = StateCode;
             this.m214.S_MS3.Add(s_ms3);
             return s_ms3;
         }


         public G_LX Add_LX_Assigned_Number(int AssignedNo)
         {
             if (this.m214.G_LX == null)
             {
                 this.m214.G_LX = new List<G_LX>();

             }
             this.SegmentCount++;
             G_LX g_lx = new G_LX();
             g_lx.S_LX = new S_LX();
             g_lx.S_LX.D_554_1 = AssignedNo.ToString();
             this.m214.G_LX.Add(g_lx);
             return g_lx;
         }


     public G_AT7 Add_G_AT7(G_LX g_lx)
    {
        G_AT7 g_at7 = new G_AT7();
        g_lx.G_AT7.Add(g_at7);
        return g_at7;
    }



         public void Add_Shipment_Status_Detail(G_AT7 g_at7, string ShipmentStatusCode, string ShipmentStatus, string AppointmentStatusCode, string AppointmentStatus, string Date, string Time, string TimeCode)
         {
             this.SegmentCount++;
             S_AT7 s_at7 = new S_AT7();
             s_at7.D_1650_1 = ShipmentStatusCode;
             s_at7.D_1651_2 = ShipmentStatus;
             s_at7.D_1652_3 = AppointmentStatusCode;
             s_at7.D_1651_4 = AppointmentStatus;
             s_at7.D_373_5 = Date;
             s_at7.D_337_6 = Time;
             s_at7.D_623_7 = TimeCode;
             g_at7.S_AT7 = s_at7;
         }

         public void Add_MS1_ESR_Property_Locationo(G_AT7 g_at7, string City, string State, string Country)
         {
             this.SegmentCount++;
             S_MS1 s_ms1 = new S_MS1();
             s_ms1.D_19_1 = City;
             s_ms1.D_156_2 = State;
             s_ms1.D_26_3 = Country;
             g_at7.S_MS1 = s_ms1;
         }


         //public void Add_K1_Remarks(string Message)
         //{
         //    if (m214.S_K1  == null)
         //    {
         //        m214.S_K1 = new List<S_K1>();
         //    }
         //    SegmentCount++;
         //    S_K1 s_k1 = new S_K1();
         //    s_k1.D_61_1 = Message;
         //    m214.S_K1.Add(s_k1);
         //}


         public void Add_LX_K1_Remarks(G_LX g_lx, string Message)
         {
             if (g_lx.S_K1_2 == null)
             {
                 g_lx.S_K1_2 = new List<S_K1_2>();
             }
             this.SegmentCount++;
             S_K1_2 s_k1_2 = new S_K1_2();
             s_k1_2.D_61_1 = Message;
             g_lx.S_K1_2.Add(s_k1_2);
         }


         public void Add_AT8_Shipment_Info(G_LX g_lx, string WeightQualifier, string WeightUnitCode, decimal Weight, decimal LadingQty, string VolunmeQualifier, decimal Volume)
         {
             if (g_lx.S_AT8 == null)
             {
                 g_lx.S_AT8 = new List<S_AT8>();
             }
             this.SegmentCount++;
             S_AT8 s_at8 = new S_AT8();
             s_at8.D_187_1 = WeightQualifier;
             s_at8.D_188_2 = WeightUnitCode;
             s_at8.D_81_3 = Weight.ToString();
             s_at8.D_80_4 = LadingQty.ToString();
             s_at8.D_184_6 = VolunmeQualifier;
             s_at8.D_183_7 = Volume.ToString();
             g_lx.S_AT8.Add(s_at8);
         }
        
         private int SegmentCount
         {
             get { return  Int32.Parse(this.m214.S_SE.D_96_1) ; }
             set {  this.m214.S_SE.D_96_1  = value.ToString();}
         }
        
         public int ControlNumber
         {
             get { return Int32.Parse(this.m214.S_ST.D_329_2); }
             set {
                 this.m214.S_ST.D_329_2 = value.ToString().PadLeft(9, '0');
                 this.m214.S_SE.D_329_2 = value.ToString().PadLeft(9, '0');
             }
         }

         public XElement GetXElement()
         {

             XmlSerializer m214Serializer = new XmlSerializer(typeof(M_214), "EdiFabric.Data.X12.V004010_214");

             using (MemoryStream ms = new MemoryStream())
             {
                 m214Serializer.Serialize(ms, this.m214);
                 ms.Position = 0;
                 using (XmlReader reader = XmlReader.Create(ms))
                 {
                     XElement element = XElement.Load(reader, LoadOptions.PreserveWhitespace);
                     return element;
                 }

             }

         }
    }
}
