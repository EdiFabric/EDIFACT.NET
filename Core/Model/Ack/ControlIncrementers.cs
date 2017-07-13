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
using System.Threading;

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// This class contains delegates used to generate control numbers.
    /// </summary>
    public class ControlIncrementers
    {
        private int _currentInterchange;

        /// <summary>
        /// The latest control number that was used in the interchange header.
        /// </summary>
        public int LatestInterchange
        {
            get { return _currentInterchange; }
        }

        private int _currentGroup;

        /// <summary>
        /// The latest control number that was used in the group header.
        /// </summary>
        public int LatestGroup
        {
            get { return _currentGroup; }
        }

        private int _currentMessage;

        /// <summary>
        /// The latest control number that was used in the message header.
        /// </summary>
        public int LatestMessage
        {
            get { return _currentMessage; }
        }

        /// <summary>
        /// The delegate to retrieve the interchange header control numbers.
        /// </summary>
        public Func<int> Interchange { get; private set; }
        /// <summary>
        /// The delegate to retrieve the group header control numbers.
        /// </summary>
        public Func<int> Group { get; private set; }
        /// <summary>
        /// The delegate to retrieve the message header control numbers.
        /// </summary>
        public Func<int> Message { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlIncrementers"/> class.
        /// This constructor auto-generates control numbers by incrementing with 1.
        /// </summary>
        /// <param name="startingInterchange">The latest control number that was used in the interchange header.</param>
        /// <param name="startingGroup">The latest control number that was used in the group header.</param>
        /// <param name="startingMessage">The latest control number that was used in the message header.</param>
        public ControlIncrementers(int startingInterchange, int startingGroup, int startingMessage)
        {
            _currentInterchange = startingInterchange;
            _currentGroup = startingGroup;
            _currentMessage = startingMessage;
            Interchange = InterchangeInc;
            Group = GroupInc;
            Message = MessageInc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControlIncrementers"/> class.
        /// This constructor allows for external control number generators to be used.
        /// If any of the parameters is null then the default auto-increment by 1 will be used instead.
        /// </summary>
        /// <param name="interchangeIncrementer">The delegate to retrieve the interchange header control numbers.</param>
        /// <param name="groupIncrementer">The delegate to retrieve the group header control numbers.</param>
        /// <param name="messageIncrementer">The delegate to retrieve the message header control numbers.</param>
        public ControlIncrementers(Func<int> interchangeIncrementer, Func<int> groupIncrementer, Func<int> messageIncrementer)
        {
            Interchange = interchangeIncrementer ?? InterchangeInc;
            Group = groupIncrementer ?? GroupInc;
            Message = messageIncrementer ?? MessageInc;
        }

        private int InterchangeInc()
        {
            return Interlocked.Increment(ref _currentInterchange);
        }

        private int GroupInc()
        {
            return Interlocked.Increment(ref _currentGroup);
        }

        private int MessageInc()
        {
            return Interlocked.Increment(ref _currentMessage);
        }
    }
}
