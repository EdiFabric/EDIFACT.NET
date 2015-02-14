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

using EdiFabric.Framework.Envelopes;
using EdiFabric.Framework.Envelopes.X12;
using EdiFabric.Framework.Messages;

namespace EdiFabric.SampleApplication
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class MyInterchange
    {
            private readonly Interchange _interchange = new Interchange();
            private readonly MyIsa _misa = new MyIsa();
            private readonly MyIea _miea = new MyIea();
  
            public MyInterchange(int controlNo, string senderQualifier, string senderId, string receiverQualifier, string receiverId, bool test )
            {

                _interchange.Groups = new List<Group>();

                _miea.SenderControlNo(controlNo);
                _misa.SenderControlNo(controlNo);
                _misa.Sender(senderQualifier, senderId);
                _misa.Receiver(receiverQualifier, receiverId);
                _misa.Test(test);

                _interchange.Isa = _misa.Isa;
                _interchange.Iea = _miea.Iea;
            }

            public MyGroup CreateGroup(int controlNo, string function, string sender, string receiver)
            {
                var mGrp = new MyGroup(controlNo, function, sender, receiver);
                _interchange.Groups.Add(mGrp.Group);
                _miea.GroupCount(_interchange.Groups.Count);
                return mGrp;
            }


           public void SetIsaDate(DateTime date)
           {
               _misa.DateTime(date);
           }


           public string GetControlNo()
           {
               return _misa.Isa.D_709_13;
           }


           public void SaveXml(string filename)
           {
               var parsedXml = _interchange.Serialize();
               using (TextWriter tw = File.CreateText(filename))
               {
                   tw.Write(parsedXml);
               }
           }

           public void SaveEdi(string filename, string segmentTerminator = null)
           {
               var interchangeContext = new InterchangeContext
                                            {
                                                SegmentTerminator =
                                                    segmentTerminator,
                                                    
                                            };
               var parsedXml = _interchange.ToEdi(interchangeContext);
               using (TextWriter tw = File.CreateText(filename))
               {
                   tw.Write(string.Concat(parsedXml));
               }
           }
    }
}
