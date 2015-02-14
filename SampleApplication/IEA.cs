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
    using System.Globalization;

    class MyIea
    {

        internal S_IEA Iea = new S_IEA();

        public MyIea()
        {
            GroupCount(0);
            SenderControlNo(1);
        }


        //IEA01 I16 Number of Included Functional Groups M N0 1/5 Must use
        //Description: A count of the number of functional groups included in an interchange
        public void GroupCount(int totalGroups)
        {
            string groups = totalGroups.ToString(CultureInfo.InvariantCulture);
            Iea.D_405_1 = groups;//.PadLeft(5, '0');
        }


        //IEA02 I12 Interchange Control Number M N0 9/9 Must use
        //Description: A control number assigned by the interchange sender
        public void SenderControlNo(int controlNo)
        {
            Iea.D_709_2 = controlNo.ToString(CultureInfo.InvariantCulture).PadLeft(9, '0');
        }

    }
}
