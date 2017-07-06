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

namespace EdiFabric.Core.Model.Edi.Edifact
{
    [Serializable()]
    public class EDIFACT_N
    {
    }

    [Serializable()]
    public class EDIFACT_AN
    {
    }

    [Serializable()]
    public class EDIFACT_DT
    {
    }

    [Serializable()]
    public class EDIFACT_TM
    {
    }

    [Serializable()]
    [EdiCodes(",UNOA,UNOB,UNOC,UNOD,UNOE,UNOF,UNOG,UNOH,UNOI,UNOJ,UNOX,UNOY,KECA,")]
    public class EDIFACT_ID_0001
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZZ,")]
    public class EDIFACT_ID_0133
    {
    }

    [Serializable()]
    [EdiCodes(
        ",1,4,5,8,9,14,18,22,30,31,33,34,51,52,53,54,55,57,58,59,61,63,65,80,82,84,85,86,87,88,89,90,91,92,103,128,129,144,145,146,147,148,Z01,ZZZ,"
        )]
    public class EDIFACT_ID_0007
    {
    }

    [Serializable()]
    [EdiCodes(",AA,BB,")]
    public class EDIFACT_ID_0025
    {
    }

    [Serializable()]
    [EdiCodes(",A,")]
    public class EDIFACT_ID_0029
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_0035
    {
    }
}
