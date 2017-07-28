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
    public class EDIFACT_A
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

    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,5,6,7,8,9,")]
    public class EDIFACT_ID_0085
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_0083
    {
    }

    [Serializable()]
    [EdiCodes(",UCD,UCF,UCI,UCM,UCS,UGH,UGT,UIB,UIH,UIR,UIT,UIZ,UNB,UNE,UNG,UNH,UNO,UNP,UNS,UNT," +
        "UNZ,USA,USB,USC,USD,USE,USF,USH,USL,USR,UST,USU,USX,USY,")]
    public class EDIFACT_ID_0135
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_0813
    {
    }

    
    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,CC,CE,EC,ED,EE,EN,ER,EU,EW,EX,IA,KE,LI,OD,RI,RT,UN,")]
    public class EDIFACT_ID_0051
    {
    }

    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,SECACK,SECAUT,")]
    public class EDIFACT_ID_0113
    {
    }

    [Serializable()]
    [EdiCodes(
        ",1,4,5,8,9,14,18,22,30,31,33,34,51,52,53,54,55,57,58,59,61,63,65,80,82,84,85,86,87,88,89,90,91,92,103,128,129,144,145,146,147,148,Z01,ZZZ,"
        )]
    public class EDIFACT_ID_0007
    {
    }
}
