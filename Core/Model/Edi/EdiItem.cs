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

using System.Collections.Generic;
using System.Linq;
using EdiFabric.Core.Annotations.Edi;
using EdiFabric.Core.Model.Edi.ErrorContexts;

namespace EdiFabric.Core.Model.Edi
{
    /// <summary>
    /// This interface marks all EDI items, which are:
    /// EDI transaction sets.
    /// EDI interchange\group headers or trailers.
    /// Error contexts.
    /// </summary>
    public abstract class EdiItem
    {
        /// <summary>
        ///  Validates an item according to its validation attributes.
        /// </summary>
        /// <returns>A list of segment error contexts. The list is empty if the item is valid.</returns>
        public List<SegmentErrorContext> Validate()
        {
            int segmentsNum;
            return Validate(out segmentsNum);
        }

        /// <summary>
        /// Validates an item according to its validation attributes.
        /// This is internally called to validate an EdiMessage.
        /// </summary>
        /// <param name="segmentsNum">The number of segments that were validated.</param>
        /// <returns>A list of segment error contexts. The list is empty if the item is valid.</returns>
        protected virtual List<SegmentErrorContext> Validate(out int segmentsNum)
        {
            var result = new List<SegmentErrorContext>();

            var visited = new HashSet<object>();
            var stack = new Stack<InstanceContext>();

            stack.Push(new InstanceContext(this));

            var segmentIndex = 0;
            var inSegmentIndex = 0;
            var inComponentIndex = 0;

            segmentsNum = 0;

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

            return result;
        }
    }
}
