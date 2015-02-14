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
using EdiFabric.Framework.Messages;

namespace EdiFabric.SampleApplication
{
    using System;
    using System.Globalization;
    using System.Xml.Linq;

    class MyGroup
    {
        internal Group Group = new Group();

        public MyGroup(int controlNo = 1, string function="", string sender="", string receiver="")
        {
            ControlNumber = controlNo;
            TransactionCount = 0;

            Function(function);
            Sender(sender);
            Receiver(receiver);
            DateTime(System.DateTime.Now);
            Agency("X");
            Version("004010");
        }

        public void Sender(string senderId)
        {
            Group.Gs.D_142_2 = senderId;
        }

        public void Receiver(string receiverId)
        {
            Group.Gs.D_124_3 = receiverId;
        }

        public void Agency(string identifier)
        {
            identifier = identifier.PadRight(1);
            Group.Gs.D_455_7 = identifier.Substring(0, 1);
        }

        public void Version(string versionNo)
        {
            versionNo = versionNo.PadRight(6);
            Group.Gs.D_480_8 = versionNo.Substring(0, 6);
        }

        public void Function(string identifierCode)
        {
            identifierCode = identifierCode.PadRight(2);
            Group.Gs.D_479_1 = identifierCode.Substring(0, 2);
        }

        public void DateTime(DateTime datetime)
        {
            DateTime(datetime.ToString("yyyyMMdd"), datetime.ToString("HHmm"));
        }

        public void DateTime(string date, string time)
        {
            date = date.PadRight(6);
            time = time.PadRight(4);

            Group.Gs.D_29_4 = date.Substring(0, 8);
            Group.Gs.D_30_5 = time.Substring(0, 4);
        }

        public void AddMessage(object msg)
        {
            Group.Messages.Add(new Message(msg));
            TransactionCount++;
        }

        private int TransactionCount
        {
            get { return Int32.Parse(Group.Ge.D_97_1); }
            set { Group.Ge.D_97_1 = value.ToString(CultureInfo.InvariantCulture); }//.PadLeft(6, '0'); }
        }

        public int ControlNumber
        {
            get { return Int32.Parse(Group.Gs.D_28_6); }
            set
            {
                Group.Gs.D_28_6 = value.ToString(CultureInfo.InvariantCulture);//.PadLeft(9, '0');
                Group.Ge.D_28_2 = value.ToString(CultureInfo.InvariantCulture);//.PadLeft(9, '0');
            }
        }
    }
}
