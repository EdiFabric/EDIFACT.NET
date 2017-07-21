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
using System.Collections.Generic;

namespace EdiFabric.Core.Model.Ack
{
    public abstract class AckContainer <T, U, V>
    {
        public T Header { get; set; }
        public List<U> Trailers { get; private set; }
        public List<V> Errors { get; private set; }
        public bool IsDuplicate { get; set; }
        public bool AckGenerated { get; set; }

        protected AckContainer()
        {
            Trailers = new List<U>();
            Errors = new List<V>();
        }

        protected AckContainer(T header, bool isDuplicate)
        {
            if (header == null) throw new ArgumentNullException("header");
            
            Header = header;
            Trailers = new List<U>();
            IsDuplicate = isDuplicate;
            Errors = new List<V>();
        }

        public abstract T ToAckHeader(int controlNr, string version);
        public abstract List<string> Validate();       
    }
}
