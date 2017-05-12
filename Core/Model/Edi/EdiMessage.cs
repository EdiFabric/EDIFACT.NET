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
using System.Linq;
using System.Reflection;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.ErrorCodes;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Model.Edi
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
                throw new Exception(string.Format("{0} was not found in {1} .", typeof(MessageAttribute).Name, type.FullName));

            Format = msgAttr.Format;
            if (Format == null) throw new Exception("Format is null");
            Version = msgAttr.Version;
            if (Version == null) throw new Exception("Version is null");
            Name = msgAttr.Id;
            if (Name == null) throw new Exception("Name is null");
        }

        public string GetControlNumber()
        {
            if (Format == "X12")
                return GetControlNumber("ST", 2);

            if (Format == "EDIFACT")
                return GetControlNumber("UNH", 1);

            throw new Exception(string.Format("GetControlNumber is not implemented for format {0} .", Format));
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

        public bool IsValid(out MessageErrorContext result, bool skipTrailer = false)
        {
            var visited = new HashSet<object>();
            var stack = new Stack<InstanceContext>();
            result = new MessageErrorContext(Name, GetControlNumber(), null);

            stack.Push(new InstanceContext(this));

            var segmentIndex = 0;
            var inSegmentIndex = 0;
            var inComponentIndex = 0;

            var segmentsNum = 0;

            while (stack.Any())
            {
                var current = stack.Pop();

                if (current.IsInstanceOfType<SegmentAttribute>())
                    segmentsNum++;

                if (current.Instance != null && !(current.Instance is string) && !visited.Add(current.Instance))
                    continue;

                current.SetIndexes(ref segmentIndex, ref inSegmentIndex, ref inComponentIndex);
                result.AddRange(current.Validate(segmentIndex, inSegmentIndex, inComponentIndex));

                var neighbours = current.GetNeigbours().Where(p => !visited.Contains(p.Instance));
                foreach (var neighbour in neighbours.Reverse())
                {
                    stack.Push(neighbour);
                }
            }

            if (!skipTrailer)
                foreach (var errorCode in ValidateStructure(segmentsNum))
                    result.Add(errorCode);

            return !result.HasErrors;
        }

        private IEnumerable<MessageErrorCode> ValidateStructure(int segmentsNum)
        {
            if (Format == "X12")
                return ValidateStructure("SE", segmentsNum);

            if (Format == "EDIFACT")
                return ValidateStructure("UNT", segmentsNum);

            throw new Exception(string.Format("ValidateStructure is not implemented for format {0} .", Format));
        }

        private IEnumerable<MessageErrorCode> ValidateStructure(string tag, int segmentsNum)
        {
            var result = new List<MessageErrorCode>();
            var controlNumber = GetControlNumber();

            if (string.IsNullOrEmpty(controlNumber))
            {
                result.Add(MessageErrorCode.ControlNumberNotMatching);
                return result;
            }

            var trailerProperty =
                GetType()
                    .GetProperties()
                    .Where(p => p.PropertyType.GetCustomAttribute<SegmentAttribute>() != null)
                    .SingleOrDefault(p => p.PropertyType.GetCustomAttribute<SegmentAttribute>().Id == tag);

            if (trailerProperty == null)
            {
                result.Add(MessageErrorCode.MessageTrailerMissing);
                return result;
            }

            var trailerValue = trailerProperty.GetValue(this);
            if (trailerValue == null)
            {
                result.Add(MessageErrorCode.MessageTrailerMissing);
                return result;
            }

            var trailer = GetValues(trailerValue);

           if(trailer.Item1 == -1)
           {
               result.Add(MessageErrorCode.SegmentsCountNotMatching);
               return result;
           }

           if (string.IsNullOrEmpty(trailer.Item2))
           {
               result.Add(MessageErrorCode.ControlNumberNotMatching);
               return result;
           }

           if (segmentsNum != trailer.Item1)
                result.Add(MessageErrorCode.SegmentsCountNotMatching);

            if (controlNumber != trailer.Item2)
                result.Add(MessageErrorCode.ControlNumberNotMatching);

            return result;
        }

        private Tuple<int, string> GetValues(object trailer)
        {
            var values =
                trailer.GetType().GetProperties().Sort().Select(property => property.GetValue(trailer)).ToList();

            if(values.Count != 2)
                return new Tuple<int, string>(-1, null);

            var sn = values[0] as string;
            var cn = values[1] as string;

            int trailerSegmentsNumber;
            if (!Int32.TryParse(sn, out trailerSegmentsNumber))
                return new Tuple<int, string>(-1, cn);

            return new Tuple<int, string>(trailerSegmentsNumber, cn);
        }
    }
}
