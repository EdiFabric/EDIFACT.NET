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
using EdiFabric.Core.Annotations.Edi;

namespace EdiFabric.Core.Model.Edi.X12
{
    [Serializable()]
    [EdiCodes(",00,01,02,03,04,05,06,")]
    public class X12_ID_I01
    {
    }

    [Serializable()]
    [EdiCodes(",00,01,")]
    public class X12_ID_I03
    {
    }

    [Serializable()]
    [EdiCodes(",01,02,03,04,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,AM,NR,SA,SN,ZZ,")]
    public class X12_ID_I05
    {
    }

    [Serializable()]
    [EdiCodes(",I,P,T,")]
    public class X12_ID_I14
    {
    }

    [Serializable()]
    public class X12_AN
    {
    }

    [Serializable()]
    public class X12_DT
    {
    }

    [Serializable()]
    public class X12_TM
    {
    }

    [Serializable()]
    public class X12_N0
    {
    }
    
    [Serializable()]
    [EdiCodes(",A,E,R,")]
    public class X12_ID_I17
    {
    }

    [Serializable()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,")]
    public class X12_ID_I18
    {
    }
}
