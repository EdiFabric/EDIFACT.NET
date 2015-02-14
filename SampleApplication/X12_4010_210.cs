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

    using Definitions.X12_004010_210;

    class X12_4010_210
    {
         public M_210 m210 = new M_210();
 
         public X12_4010_210() : this(1,"","",DateTime.Now,0,"")
         {
         }

         public X12_4010_210(int ControlNo, string InvoiceNo, string MethodOfPayment, DateTime InvoiceDate, decimal NetAmountDue, string SCAC )
         {
             this.m210.S_ST = new S_ST();
             this.m210.S_SE = new S_SE();
             this.m210.S_ST.D_143_1 = "210";
             this.m210.S_B3 = new S_B3();
             this.ControlNumber = ControlNo; //ST_D_329_2 
             this.InvoiceNo = InvoiceNo;     //S_B3.D_76_2
             this.MethodOfPayment = MethodOfPayment; //S_B3.D_146_4
             this.InvoiceDateTime = InvoiceDate;     //S_B3.D_373_6

             this.NetAmountDue = NetAmountDue; //S_B3.D_193_7 

             this.SCAC = SCAC; //D_140_11
             this.SegmentCount = 3; //ST /SE /B3
         }

         public string InvoiceNo
         {
             get { return this.m210.S_B3.D_76_2; }
             set { this.m210.S_B3.D_76_2 = value; }
         }

         public string ShipMentID
         {
             get { return this.m210.S_B3.D_145_3; }
             set { this.m210.S_B3.D_145_3 = value; }
         }

         public string MethodOfPayment
         {
             get { return this.m210.S_B3.D_146_4; }
             set { this.m210.S_B3.D_146_4 = value; }
         }

         public string WeightUnit
         {
             get { return this.m210.S_B3.D_188_5; }
             set { this.m210.S_B3.D_188_5 = value; }
         }

         public string InvoiceDate
         {
             get { return this.m210.S_B3.D_373_6; }
             set { this.m210.S_B3.D_373_6 = value; }
         }

         public DateTime InvoiceDateTime
         {
             set { this.m210.S_B3.D_373_6 = value.ToString("yyyyMMdd");}
         }

         public decimal NetAmountDue
         {
             get { return Convert.ToDecimal(this.m210.S_B3.D_193_7) / 100; }
             set { this.m210.S_B3.D_193_7 = ((int)(value*100)).ToString(); }
         }


         public string Correction
         {
             get { return this.m210.S_B3.D_202_8; }
             set { this.m210.S_B3.D_202_8 = value; }
         }


         public void AddDeliveryDate(DateTime Date, string DateTypeCode)
         {

             this.AddDeliveryDate(Date.ToString("yyyyMMdd"), DateTypeCode);
         }

         public void AddDeliveryDate(string Date, string DateTypeCode)
         {
             this.m210.S_B3.D_32_9 = Date;
             this.m210.S_B3.D_374_10 = DateTypeCode;
         }


         public string SCAC
         {
             get { return this.m210.S_B3.D_140_11; }
             set { this.m210.S_B3.D_140_11 = value; }
         }


         public void Add_N9_ReferenceID(string IDType, string ID)
         {

             if (this.m210.S_N9 == null)
             {
                 this.m210.S_N9 = new List<S_N9>();

             }
             this.SegmentCount++;
             S_N9 S_N9 = new S_N9();
             S_N9.D_128_1 = IDType;
             S_N9.D_127_2 = ID;
             this.m210.S_N9.Add(S_N9);
         }

         public void Add_G62_Date(string DateType, DateTime Date)
         {
             this.Add_G62_Date(DateType, Date.ToString("yyyyMMdd"));
         }

         public void Add_G62_Date(string DateType, string Date)
         {

             if (this.m210.S_G62 == null)
             {
                 this.m210.S_G62 = new List<S_G62>();

             }
             this.SegmentCount++;
             S_G62 S_G62 = new S_G62();
             S_G62.D_432_1 = DateType;
             S_G62.D_373_2 = Date; //CCYYMMDD
             this.m210.S_G62.Add(S_G62);

         }

         public G_N1 Add_N1_Name(string NameType, string Name)
         {
             if (this.m210.G_N1 == null)
             {
                 this.m210.G_N1 = new List<G_N1>();
   
             }
             this.SegmentCount++;
             G_N1 G_N1;

             G_N1 = new G_N1();
             G_N1.S_N1 = new S_N1();
             G_N1.S_N1.D_98_1 = NameType; 
             if (Name.Length != 0)
                G_N1.S_N1.D_93_2 = Name; 
             this.m210.G_N1.Add(G_N1);
             return G_N1;
         }

         public void Add_N3_Address(G_N1 g_n1, string Address1)
         {
             this.Add_N3_Address(g_n1, Address1, null);
         }


         public void Add_N3_Address(G_N1 g_n1, string Address1, string Address2)
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


         public void Add_N4_Geographic(G_N1 g_n1, string City, string State, string Zip)
         {
             this.SegmentCount++;
             g_n1.S_N4 = new S_N4();
             g_n1.S_N4.D_19_1 = City;
             g_n1.S_N4.D_156_2 = State;
             g_n1.S_N4.D_116_3 = Zip; 
         }


         public G_LX Add_LX_Invoice_Line(int AssignedNo)
         {
             if (this.m210.G_LX == null)
             {
                 this.m210.G_LX = new List<G_LX>();
    
             }
             this.SegmentCount++;
             G_LX g_lx = new G_LX();
             g_lx.S_LX = new S_LX();
             g_lx.S_LX.D_554_1 = AssignedNo.ToString();
             this.m210.G_LX.Add(g_lx);
             return g_lx;
         }

         public S_L5 Add_LX_L5_Description(G_LX g_lx, int LineNo, string LadingDescription, string CommodityCode, string CommodityCodeType)
         {
             if (g_lx.S_L5 == null)
             {
                 g_lx.S_L5 = new List<S_L5>();
             }
             this.SegmentCount++;
             S_L5 S_L5 = new S_L5();
             S_L5.D_213_1 = LineNo.ToString(); // "1";
             S_L5.D_79_2 = LadingDescription;// "PETROLEUM OILS,";
             S_L5.D_22_3 = CommodityCode;// "15525002";
             S_L5.D_23_4 = CommodityCodeType; // "N";
             g_lx.S_L5.Add(S_L5);
             return S_L5;
         }

         public S_L0 Add_LX_L0_Qty_Weight(G_LX g_lx, int LineNo, int Weight, string WeightType, int Qty, string QtyType, string WeightUnitCode)
         {
             if (g_lx.S_L0 == null)
             {
                 g_lx.S_L0 = new List<S_L0>();
             }
             this.SegmentCount++;
             S_L0 S_L0 = new S_L0();
             S_L0.D_213_1 = LineNo.ToString();
             S_L0.D_81_4 = Weight.ToString(); 
             S_L0.D_187_5 = WeightType;// G = Gross / N = Actual Net / B = Billed
             S_L0.D_80_8 = Qty.ToString(); ////Lading Quantity
             S_L0.D_211_9 = QtyType;  //"PLT";  // Lading Quantity CAS = Case CNT = Container CTN = Carton CUB = Cube PCS = Pieces PLT = Pallet  
             S_L0.D_188_11 = WeightUnitCode; //"L";  //Weight Unit Code L = Pounds
             g_lx.S_L0.Add(S_L0);
             return S_L0;
         }

         public S_L1 Add_LX_L1_Rate_Charges(G_LX g_lx, int LineNo, decimal FreightRate, string RateType, decimal Charge)
         {
             if (g_lx.S_L1 == null)
             {
                 g_lx.S_L1 = new List<S_L1>();
             }
             this.SegmentCount++;
             S_L1 S_L1 = new S_L1();
             S_L1.D_213_1 = LineNo.ToString();
             S_L1.D_60_2 = ((int)(FreightRate * 100)).ToString();
             S_L1.D_122_3 = RateType;
             S_L1.D_58_4 = ((int)(Charge * 100)).ToString();
             g_lx.S_L1.Add(S_L1);
             return S_L1;
         }

         public S_L7 Add_LX_L7_Tarrif_Ref(G_LX g_lx, int LineNo, string FreightCodeClass)
         {
             if (g_lx.S_L7 == null)
             {
                 g_lx.S_L7 = new List<S_L7>();
             }
             this.SegmentCount++;
             S_L7 S_L7 = new S_L7();
             S_L7.D_213_1 = LineNo.ToString();
             S_L7.D_59_7 = FreightCodeClass; // "0E60";
             g_lx.S_L7.Add(S_L7);
             return S_L7;
         }

         public void Add_L3_Totals(decimal weight, string WeightType, decimal Charge, int LadingQty)
         {
            this.SegmentCount++;
            S_L3 S_L3 = new S_L3();
            S_L3.D_81_1 = ((int)(weight * 100)).ToString();
            S_L3.D_187_2 = WeightType; //"G";
            S_L3.D_58_5 = ((int)(Charge * 100)).ToString();
            S_L3.D_80_11 = ((int)(LadingQty)).ToString();
            this.m210.S_L3 = S_L3;
         }

         private int SegmentCount
         {
             get { return  Int32.Parse(this.m210.S_SE.D_96_1) ; }
             set {  this.m210.S_SE.D_96_1  = value.ToString();}
         }
        
         public int ControlNumber
         {
             get { return Int32.Parse(this.m210.S_ST.D_329_2); }
             set {
                 this.m210.S_ST.D_329_2 = value.ToString().PadLeft(9, '0');
                 this.m210.S_SE.D_329_2 = value.ToString().PadLeft(9, '0');
             }
         }


         public XElement GetXElement()
         {

             XmlSerializer m210Serializer = new XmlSerializer(typeof(M_210), "EdiFabric.Data.X12.V004010_210");

             using (MemoryStream ms = new MemoryStream())
             {
                 m210Serializer.Serialize(ms, this.m210);
                 ms.Position = 0;
                 using (XmlReader reader = XmlReader.Create(ms))
                 {
                     XElement element = XElement.Load(reader,LoadOptions.PreserveWhitespace);
                     return element;
                 }
 
             }

         }

    }
}
