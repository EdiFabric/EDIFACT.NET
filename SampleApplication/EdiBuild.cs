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

using System;
using EdiFabric.Definitions.X12_004010_214;
using G_LX = EdiFabric.Definitions.X12_004010_210.G_LX;
using G_N1 = EdiFabric.Definitions.X12_004010_210.G_N1;

namespace EdiFabric.SampleApplication
{
    public class EdiBuildX12
    {

        public void Create210()
        {
            DateTime testDate = DateTime.Now;
            var mInterchange = new MyInterchange(1, "01", "ABCCOM", "01", "999999999", true);

            var mGroup = mInterchange.CreateGroup(1, "IM", "006998397", "123456789");
            var ediMessage = new X12_4010_210(1, "2509121213", "PP", testDate, 183.04M, "XXXX")
                                 {
                                     ShipMentID =
                                         "8000281336"
                                 };
            ediMessage.Add_N9_ReferenceID("PO", "SM12003301");
            ediMessage.Add_N9_ReferenceID("PO", "SM121231231");
            ediMessage.Add_N9_ReferenceID("PO", "SM1asdasda1");
            ediMessage.AddDeliveryDate(DateTime.Parse("08/01/2011"), "017");
            ediMessage.Add_G62_Date("86", "20110801");

            G_N1 gN1 = ediMessage.Add_N1_Name("CN", "AAA HARDWARE");
            ediMessage.Add_N3_Address(gN1, "9805 POPLAR ST");
            ediMessage.Add_N4_Geographic(gN1, "LEADVILLE", "CO", "80461");

            gN1 = ediMessage.Add_N1_Name("SH", "BBB OIL COMPANY");
            ediMessage.Add_N3_Address(gN1, "2361 S DIXIE HWY");
            ediMessage.Add_N4_Geographic(gN1, "LIMA", "OH", "45802");

            gN1 = ediMessage.Add_N1_Name("BT", "ANY PAY AGENT");
            ediMessage.Add_N3_Address(gN1, "ATTN: DONNA SMITH", "PO BOX 16789");
            ediMessage.Add_N4_Geographic(gN1, "ANYTOWN", "MO", "12345-6789");

            G_LX gLx = ediMessage.Add_LX_Invoice_Line(1);
            ediMessage.Add_LX_L5_Description(gLx, 1, "PETROLEUM OILS,", "15525002", "N");
            ediMessage.Add_LX_L0_Qty_Weight(gLx, 1, 138, "N", 1, "PLT", "L");
            ediMessage.Add_LX_L1_Rate_Charges(gLx, 1, 1.20M, "PH", 183.04M);
            ediMessage.Add_LX_L7_Tarrif_Ref(gLx, 1, "0E60");


            ediMessage.Add_LX_Invoice_Line(2);

            ediMessage.Add_L3_Totals(1.38M, "G", 183.04M, 1);
            
            mGroup.AddMessage(ediMessage.m210);

            mInterchange.SaveXml("Test210.xml");
            mInterchange.SaveEdi("Test210.edi");
            mInterchange.SaveEdi("Test210.txt", Environment.NewLine);
        }


        public void Create214()
        {
            var mInterchange = new MyInterchange(1, "ZZ", "STDSP5AC", "ZZ", "GTNEXUS", false);

            MyGroup mGroup = mInterchange.CreateGroup(263, "QM", "STDSP5AC", "STDCERTSH");
            var ediMessage = new X12_4010_214(1, "STDSP5Z30001", "STDSP5Z30001", "ZZAC");

            ediMessage.Add_L11_Reference("UA007", "AF");
            ediMessage.Add_L11_Reference("Unidentified Airlines", "SCA");

            Definitions.X12_004010_214.G_N1 gN1A = ediMessage.Add_N1_Name("SH", "Shipper Name", "94", "CNZHSPC-TMPF");
            ediMessage.Add_N3_Address(gN1A, "Chengxin Middle Road", "Xinqian Town, Huangyan District");
            ediMessage.Add_N4_Geographic(gN1A, "Taizhou", "", "", "CN", "UN", "CNTIZ");
            ediMessage.Add_G62_Date(gN1A, "69", "20110812");

            Definitions.X12_004010_214.G_N1 gN1B = ediMessage.Add_N1_Name("OT", "Shanghai International Airport", "94", "SHA");
            ediMessage.Add_N4_Geographic(gN1B, "Shanghai", "", "", "CN", "IA", "SHA");

            Definitions.X12_004010_214.G_N1 gN1C = ediMessage.Add_N1_Name("DT", "DFW International Airport", "94", "DFW");
            ediMessage.Add_N4_Geographic(gN1C, "Dallas", "TX", "", "US", "IA", "DFW");

            Definitions.X12_004010_214.G_N1 gN1D = ediMessage.Add_N1_Name("CN", "Consignee Name", "94", "STDCN");
            ediMessage.Add_N3_Address(gN1D, "2560 W. Commerce Street");
            ediMessage.Add_N4_Geographic(gN1D, "Dallas", "TX", "", "US", "UN", "USDAL");
            ediMessage.Add_G62_Date(gN1D, "17", "20110815");

            ediMessage.Add_MS3_Interline_Info("UA", "O", "", "A");

            Definitions.X12_004010_214.G_LX gLx = ediMessage.Add_LX_Assigned_Number(1);

            G_AT7 gAt7 = ediMessage.Add_G_AT7(gLx);
            ediMessage.Add_Shipment_Status_Detail(gAt7, "AF", "NS", "", "", "20110812", "1100", "LT");
            ediMessage.Add_LX_K1_Remarks(gLx, "comments go here");
            ediMessage.Add_AT8_Shipment_Info(gLx, "G", "K", 100.105M, 106M, "X", 20.826M);
            ediMessage.Add_MS1_ESR_Property_Locationo(gAt7, "SHA", "0I", "CN");

            mGroup.AddMessage(ediMessage.m214);

            mInterchange.SaveXml("Test214.xml");
            mInterchange.SaveEdi("Test214.edi");
            mInterchange.SaveEdi("Test214.txt", Environment.NewLine);
        }
    }
}
