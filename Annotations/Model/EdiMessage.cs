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
using System.Data;
using System.Linq;
using System.Reflection;
using EdiFabric.Annotations.Edi;
using EdiFabric.Annotations.Validation;

namespace EdiFabric.Annotations.Model
{
    public class EdiMessage : IEdiItem
    {
        /// <summary>
        /// The message ID.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The message version (derived from the group if not explicitly set in the message).
        /// </summary>
        public string Version { get; private set; }
        /// <summary>
        /// The message format (X12 or Edifact or other).
        /// </summary>
        public string Format { get; private set; }

        public EdiMessage()
        {
            var type = GetType();
            var msgAttr = type.GetCustomAttribute<MessageAttribute>();
            if (msgAttr == null)
                throw new Exception(string.Format("[MessageAttribute] was not found in {0} .", type.FullName));

            Format = msgAttr.Format;
            if (Format == null) throw new NoNullAllowedException("Format");
            Version = msgAttr.Version;
            if (Version == null) throw new NoNullAllowedException("Version");
            Name = msgAttr.Id;
            if (Name == null) throw new NoNullAllowedException("Name");
        }

        public string GetControlNumber()
        {
            if (Format == "X12")
                return GetControlNumber("ST", 2);

            if (Format == "EDIFACT")
                return GetControlNumber("UNH", 1);

            throw new NotImplementedException(Format);
        }

        private string GetControlNumber(string tag, int position)
        {
            var headerProperty =
                GetType()
                    .GetProperties()
                    .Where(p => p.PropertyType.GetCustomAttribute<SegmentAttribute>() != null)
                    .SingleOrDefault(p => p.PropertyType.GetCustomAttribute<SegmentAttribute>().Id == tag);

            if (headerProperty == null)
                throw new Exception(string.Format("{0} segment was not found.", tag));

            var headerValue = headerProperty.GetValue(this);
            var cnProperty =
                headerValue.GetType()
                    .GetProperties()
                    .SingleOrDefault(p => p.GetCustomAttribute<PosAttribute>().Pos == position);

            if (cnProperty == null)
                throw new Exception(string.Format("{0} segment does not contain control number.", tag));

            return cnProperty.GetValue(headerValue) as string;
        }

        public bool IsValid(out List<SegmentErrorContext> results)
        {
            var visited = new HashSet<object>();
            var stack = new Stack<InstanceContext>();
            results = new List<SegmentErrorContext>();

            stack.Push(new InstanceContext(this));

            var segmentIndex = 0;
            var inSegmentIndex = 0;
            var inComponentIndex = 0;

            while (stack.Any())
            {
                var current = stack.Pop();

                if (current.Instance != null && !(current.Instance is string) && !visited.Add(current.Instance))
                    continue;

                current.SetIndexes(ref segmentIndex, ref inSegmentIndex, ref inComponentIndex);
                results.AddRange(current.Validate(segmentIndex, inSegmentIndex, inComponentIndex));

                var neighbours = current.GetNeigbours().Where(p => !visited.Contains(p.Instance));
                foreach (var neighbour in neighbours.Reverse())
                {
                    stack.Push(neighbour);
                }
            }

            return !results.Any();
        }                
    }
}
