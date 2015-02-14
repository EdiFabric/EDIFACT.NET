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

using EdiFabric.Framework.Envelopes.X12;

namespace EdiFabric.SampleApplication
{
    using System;
    using System.Globalization;

    class MyIsa
    {
        internal S_ISA Isa = new S_ISA();

        public MyIsa()
        {
            Authorizaton("00", "");
            Security("00", "");
            Sender("01", "");
            Receiver("01", "");
            DateTime(System.DateTime.Now);
            Agency("U");
            Version("00401"); // major version - should match part of group versions
            SenderControlNo(1);
            Acknowledgment(false);
            Test(false);
            Separator('>');
        }

        //ISA01 I01 Authorization Information Qualifier M ID 2/2 Must use
        //Description: Code to identify the type of information in the Authorization Information
        //ISA02 I02 Authorization Information M AN 10/10 Must use
        //Description: Information used for additional identification or authorization of the interchange
        //sender or the data in the interchange; the type of information is set by the Authorization
        //Information Qualifier (I01)
        public void Authorizaton(string qualifier, string information)
        {
            qualifier = qualifier.PadRight(2);
            information = information.PadRight(10);

            Isa.D_744_1 = qualifier.Substring(0, 2);
            Isa.D_745_2 = information.Substring(0, 10);
        }


        //ISA03 I03 Security Information Qualifier M ID 2/2 Must use
        //Description: Code to identify the type of information in the Security Information
        //ISA04 I04 Security Information M AN 10/10 Must use
        //Description: This is used for identifying the security information about the interchange
        //sender or the data in the interchange; the type of information is set by the Security
        //Information Qualifier (I03)
        public void Security(string qualifier, string information)
        {
            qualifier = qualifier.PadRight(2);
            information = information.PadRight(10);

            Isa.D_746_3 = qualifier.Substring(0, 2);
            Isa.D_747_4 = information.Substring(0, 10);
        }

        //ISA05 I05 Interchange ID Qualifier M ID 2/2 Must use
        //Description: Qualifier to designate the system/method of code structure used to designate
        //the sender or receiver ID element being qualified
        //ISA06 I06 Interchange Sender ID M AN 15/15 Must use
        //Description: Identification code published by the sender for other parties to use as the
        //receiver ID to route data to them; the sender always codes this value in the sender ID element
        public void Sender(string qualifier, string senderId)
        {
            qualifier = qualifier.PadRight(2);
            senderId = senderId.PadRight(15);

            Isa.D_704_5 = qualifier.Substring(0, 2);
            Isa.D_705_6 = senderId.Substring(0, 15);
        }

        //ISA07 I05 Interchange ID Qualifier M ID 2/2 Must use
        //Description: Qualifier to designate the system/method of code structure used to designate
        //the sender or receiver ID element being qualified
        //ISA08 I07 Interchange Receiver ID M AN 15/15 Must use
        //Description: Identification code published by the receiver of the data; When sending, it is
        //used by the sender as their sending ID, thus other parties sending to them will use this as a
        //receiving ID to route data to them
        public void Receiver(string qualifier, string receiverId)
        {
            qualifier = qualifier.PadRight(2);
            receiverId = receiverId.PadRight(15);

            Isa.D_704_7 = qualifier.Substring(0, 2);
            Isa.D_706_8 = receiverId.Substring(0, 15);
        }


        //ISA09 I08 Interchange Date M DT 6/6 Must use
        //Description: Date of the interchange
        //ISA10 I09 Interchange Time M TM 4/4 Must use
        //Description: Time of the interchange YYMMDD
        public void DateTime(DateTime datetime)
        {
            DateTime(datetime.ToString("yyMMdd"), datetime.ToString("HHmm"));
        }

        public void DateTime(string date, string time)
        {
            date = date.PadRight(6);
            time = time.PadRight(4);

            Isa.D_373_9 = date.Substring(0, 6);
            Isa.D_337_10 = time.Substring(0, 4);
        }


        //ISA11 I10 Interchange Control Standards Identifier M ID 1/1 Must use
        //Description: Code to identify the agency responsible for the control standard used by the
        //message that is enclosed by the interchange header and trailer
        //value "U", indicating "U.S. EDI Community of ASC X12, TDCC, and UCS"

        public void Agency(string identifier)
        {
            identifier = identifier.PadRight(1);
            Isa.D_726_11 = identifier.Substring(0, 1);
        }


        //ISA12 I11 Interchange Control Version Number M ID 5/5 Must use
        //Description: Code specifying the version number of the interchange control segments

        public void Version(string versionNo)
        {
            versionNo = versionNo.PadRight(5);
            Isa.D_703_12 = versionNo.Substring(0, 5);
        }

        //ISA13 I12 Interchange Control Number M N0 9/9 Must use
        //Description: A control number assigned by the interchange sender
        public void SenderControlNo(int controlNo)
        {
            Isa.D_709_13 = controlNo.ToString(CultureInfo.InvariantCulture).PadLeft(9, '0');
        }

        //public string SenderControlString
        //{
        //    get { return isa.D_709_13; }
        //    set { isa.D_709_13 = value.PadLeft(9, '0'); }
        //}
      

        //ISA14 I13 Acknowledgment Requested M ID 1/1 Must use
        //Description: Code sent by the sender to request an interchange acknowledgment (TA1)
        public void Acknowledgment(bool requestAck)
        {
            Isa.D_749_14 = requestAck ? "1" : "0";
        }

        //ISA15 I14 Usage Indicator M ID 1/1 Must use
        //Description: Code to indicate whether data enclosed by this interchange envelope is test,
        //production or information

        public void Test(bool isTesting)
        {
            Isa.D_748_15 = isTesting ? "T" : "P";
        }

        //ISA16 I15 Component Element Separator M 1/1 Must use
        //Description: Type is not applicable; the component element separator is a delimiter and not
        //a data element; this field provides the delimiter used to separate component data elements
        //within a composite data structure; this value must be different than the data element
        //separator and the segment terminator

        public void Separator(char character)
        {
            Isa.D_701_16 = character.ToString(CultureInfo.InvariantCulture);
        }

    }
}
