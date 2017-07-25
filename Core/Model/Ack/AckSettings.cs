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

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// This class contains all of the configuration settings.
    /// </summary>
    public abstract class AckSettings<T, U>
    {
        /// <summary>
        /// The delegates to generate control numbers for interchange, group and message.
        /// </summary>
        public ControlIncrementers Incrementers { get; set; }
        /// <summary>
        /// The acknowledgment handler. It is raised after reaching the end of each group as the EDI document is read along. 
        /// </summary>
        public EventHandler<AckEventArgs<T, U>> AckHandler { get; set; }        
        /// <summary>
        /// The message handler. It is raised after reaching the end of each message as the EDI document is read along.
        /// </summary>
        public EventHandler<MessageEventArgs<T, U>> MessageHandler { get; set; }
        /// <summary>
        /// Indicates whether to detect duplicate messages within the same group.
        /// </summary>
        public bool TransactionSetDuplicates { get; set; }
        /// <summary>
        /// Indicates whether to detect duplicate groups within the same interchange.
        /// </summary>
        public bool GroupDuplicates { get; set; }
        /// <summary>
        /// A delegate to detect duplicate interchanges.
        /// </summary>
        public Func<string, bool> InterchangeDuplicates { get; set; }
        /// <summary>
        /// Controls the generation of technical acknowledgment.
        /// By default it generates it according to the ISA14 flag (for X12) or UNB9 flag (for EDIFACT). 
        /// </summary>
        public TechnicalAck TechnicalAck { get; set; }
        /// <summary>
        /// Indicates if message ack segments are generated for valid messages.
        /// </summary>
        public bool GenerateForValidMessages { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="AckSettings{T, U}"/> class.
        /// The default constructor initializes the default settings:
        /// No ack or message handlers, auto incrementers, ack version is set to X12_997 and all other options are turned off.
        /// </summary>
        protected AckSettings()
        {
            Incrementers = new ControlIncrementers(0, 0, 0);
            AckHandler = null;
            MessageHandler = null;
            TransactionSetDuplicates = false;
            GroupDuplicates = false;
            InterchangeDuplicates = null;
            TechnicalAck = TechnicalAck.Default;
            GenerateForValidMessages = false;
        }
    }
}
