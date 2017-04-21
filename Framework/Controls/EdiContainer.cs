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
using EdiFabric.Framework.Parsers;

namespace EdiFabric.Framework.Controls
{
    /// <summary>
    /// This class represents an EDI interchange or group. 
    /// Each EDI container has a header, a trailer and a collection of items of the same type.
    /// </summary>
    /// <typeparam name="T">The header type.</typeparam>
    /// <typeparam name="TU">The type of items.</typeparam>
    /// <typeparam name="TV">The trailer type.</typeparam>
    public class EdiContainer<T, TU, TV> 
    {
        /// <summary>
        /// EDI header (interchange or group). 
        /// </summary>
        public T Header { get; private set; }
        private readonly Func<T, int, TV> _trailerSetter;
        private readonly List<TU> _items = new List<TU>();
        private readonly Separators _defaultSeparators;
        /// <summary>
        /// The items (groups or messages).
        /// </summary>
        public IReadOnlyCollection<TU> Items
        {
            get { return _items.AsReadOnly(); }
        }
        /// <summary>
        /// EDI trailer (interchange or group). 
        /// </summary>
        public TV Trailer { get; private set; }

        /// <summary>
        /// Protected constructor. Initializes a new instance of the <see cref="EdiContainer{T, TU, TV}"/> class. 
        /// </summary>
        /// <param name="header">The header type.</param>
        /// <param name="trailerSetter">The function to automatically set the trailer.</param>
        /// <param name="defaultSeparators">The default separators.</param>
        protected EdiContainer(T header, Func<T, int, TV> trailerSetter, Separators defaultSeparators)
        {
            if (trailerSetter == null) throw new ArgumentNullException("trailerSetter");
            if (defaultSeparators == null) throw new ArgumentNullException("defaultSeparators");

            Header = header;
            _trailerSetter = trailerSetter;
            _defaultSeparators = defaultSeparators;
        }

        /// <summary>
        /// Adds an item.
        /// </summary>
        /// <param name="item">The item to add.</param>
        public void AddItem(TU item)
        {
            if (item == null) throw new ArgumentNullException("item");

            _items.Add(item);
            if (Header != null)
                Trailer = _trailerSetter(Header, _items.Count);
        }

        /// <summary>
        /// Adds a collection of items.
        /// </summary>
        /// <param name="items">The items to add.</param>
        public void AddItems(IEnumerable<TU> items)
        {
            if (items == null) throw new ArgumentNullException("items");

            _items.AddRange(items);
            if (Header != null)
                Trailer = _trailerSetter(Header, _items.Count);
        }

        /// <summary>
        /// Generates a collection of EDI segments from the header, the items and the trailer.
        /// </summary>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI segments.</returns>
        public virtual IEnumerable<string> GenerateEdi(Separators separators = null)
        {
            var result = new List<string>();
            var currentSeparators = separators ?? _defaultSeparators;

            if (Header != null)
                result.Add(ToSegmentEdi(Header, currentSeparators));
            foreach (var item in Items)
            {
                result.AddRange(ToMessageEdi(item, currentSeparators));
            }
            if (Trailer != null)
                result.Add(ToSegmentEdi(Trailer, currentSeparators));

            return result;
        }

        /// <summary>
        /// Converts an EDI document instance to a collection of EDI segments.
        /// </summary>
        /// <param name="item">The EDI document instance.</param>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI segments.</returns>
        protected static IEnumerable<string> ToMessageEdi(object item, Separators separators)
        {
            var parseTree = new TransactionSet(item.GetType(), item);
            //var segments = parseTree.Descendants().OfType<Segment>().Where(s => s.Children.Count > 0).Reverse().ToList();
            var segments = parseTree.Descendants().OfType<Segment>().Reverse().ToList();

            var result = segments.Select(segment => segment.GenerateSegment(separators));

            if (parseTree.EdiName == "TA1") return result;

            var trailerValues = segments.PullTrailerValues();
            return SetTrailer(result.ToList(), separators, trailerValues.Item2, trailerValues.Item1);
        }

        /// <summary>
        /// Converts an EDI document instance to a collection of EDI segments.
        /// </summary>
        /// <param name="item">The EDI document instance.</param>
        /// <param name="separators">The EDI separators.</param>
        /// <returns>The collection of EDI segments.</returns>
        protected static string ToSegmentEdi(object item, Separators separators)
        {
            var type = item.GetType();
            var parseTree = new Segment(type, type.Name, type.Name, item);
            return parseTree.GenerateSegment(separators);
        }

        private static IEnumerable<string> SetTrailer(List<string> segments, Separators separators, string trailerTag, string controlNumber)
        {
            if (!segments.Any()) return segments;
            var segmentsCount = segments.Count();

            string trailer = null;

            if (segments.Last().StartsWith(trailerTag + separators.DataElement, StringComparison.Ordinal) ||
                segments.Last().StartsWith(trailerTag + separators.Segment, StringComparison.Ordinal))
                trailer = segments.Last();

            if (trailer != null)
                segments.Remove(trailer);
            else
                segmentsCount = segmentsCount + 1;

            trailer = trailerTag + separators.DataElement + segmentsCount + separators.DataElement +
                      controlNumber +
                      separators.Segment;

            segments.Add(trailer);

            return segments;
        }
    }
}

