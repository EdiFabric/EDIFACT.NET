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
using System.Globalization;
using System.Linq;

namespace EdiFabric.Framework.Envelopes
{
    /// <summary>
    /// The context of the interchange
    /// Contains the separators, the format and the namespace 
    /// </summary>
    public class InterchangeContext : IEquatable<InterchangeContext>
    {
        /// <summary>
        /// Separator for segments
        /// </summary>
        public string SegmentTerminator { get; set; }

        /// <summary>
        /// Separator for component data elements
        /// </summary>
        public string ComponentDataElementSeparator { get; set; }

        /// <summary>
        /// Release indicator for escaping terminators
        /// </summary>
        public string ReleaseIndicator { get; set; }

        ///<summary>
        /// Separator for data elements
        /// </summary>
        public string DataElementSeparator { get; set; }

        /// <summary>
        /// Separator for repetitions of data elements
        /// </summary>
        public string RepetitionSeparator { get; set; }

        /// <summary>
        /// The format of the interchange, e.g. the format of the envelope
        /// </summary>
        public EdiFormats Format { get; set; }

        /// <summary>
        /// The target namespace for that format
        /// </summary>
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterchangeContext"/> class.
        /// </summary>
        public InterchangeContext()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterchangeContext"/> class.
        /// This extracts the separators from the contents of the edi message.
        /// </summary>
        /// <param name="contents">The edi message</param>
        public InterchangeContext(string contents)
        {
            if (contents == null) throw new ArgumentNullException("contents");

            contents = contents.Replace(Environment.NewLine, string.Empty);

            // X12
            if (contents.ToUpper().StartsWith(EdiSegments.Isa))
            {
                try
                {
                    // Parse X12 separators, they are always contained within the envelope
                    DataElementSeparator = contents[3].ToString(CultureInfo.InvariantCulture);
                    var isa = string.Concat(contents.Take(106));
                    var isaElements = isa.Split(DataElementSeparator[0]);
                    ComponentDataElementSeparator = string.Concat(isaElements[16].First());
                    // Repetition is either the defaukt ^ or else if explicitly specified when U is present
                    RepetitionSeparator = isaElements[11] != "U" ? isaElements[11] : "^";
                    // Handle carriage return\new line segment terminators
                    var st = isaElements[16].Skip(1).DefaultIfEmpty('G').First();
                    SegmentTerminator = st.ToString(CultureInfo.InvariantCulture);
                    if (SegmentTerminator == " " || string.IsNullOrEmpty(SegmentTerminator)
                        || SegmentTerminator == "G") SegmentTerminator = Environment.NewLine;
                    // No release terminator for X12
                    ReleaseIndicator = "";
                    Format = EdiFormats.X12;
                    TargetNamespace = Namespaces.X12;
                }
                catch (Exception ex)
                {
                    throw new ParserException("Can't find X12 interchange delimiters", ex);
                }
            }

            // Edifact
            if (contents.ToUpper().StartsWith(EdiSegments.Unb))
            {
                //  Default Edifact separators
                ComponentDataElementSeparator = ":";
                DataElementSeparator = "+";
                ReleaseIndicator = "?";
                RepetitionSeparator = "*";
                SegmentTerminator = "'";
                Format = EdiFormats.Edifact;
                TargetNamespace = Namespaces.Edifact;
            }

            // Edifact with non default separators, set on the UNA segment
            if (contents.ToUpper().StartsWith(EdiSegments.Una))
            {
                try
                {
                    //  Parse UNA separators
                    var una = contents.Replace(EdiSegments.Una, "").Take(6).ToList();

                    ComponentDataElementSeparator = una[0].ToString(CultureInfo.InvariantCulture);
                    DataElementSeparator = una[1].ToString(CultureInfo.InvariantCulture);
                    ReleaseIndicator = una[3].ToString(CultureInfo.InvariantCulture);
                    RepetitionSeparator = "*";
                    SegmentTerminator = una[5].ToString(CultureInfo.InvariantCulture);
                    Format = EdiFormats.Edifact;
                    TargetNamespace = Namespaces.Edifact;
                }
                catch (Exception ex)
                {
                    throw new ParserException("Can't find UNA interchange delimiters", ex);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterchangeContext"/> class.
        /// This gets the default separators per format.
        /// </summary>
        /// <param name="format">The format</param>
        public InterchangeContext(EdiFormats format)
        {
            switch (format)
            {
                case EdiFormats.Edifact:
                    ComponentDataElementSeparator = ":";
                    DataElementSeparator = "+";
                    ReleaseIndicator = "?";
                    RepetitionSeparator = "*";
                    SegmentTerminator = "'";
                    Format = EdiFormats.Edifact;
                    break;
                case EdiFormats.X12:
                    ComponentDataElementSeparator = ":";
                    DataElementSeparator = "*";
                    ReleaseIndicator = "";
                    RepetitionSeparator = "^";
                    SegmentTerminator = "~";
                    Format = EdiFormats.X12;
                    break;
                default:
                    throw new ParserException("Unsupported format: " + format);
            }
        }

        /// <summary>
        /// If the separators are format default.
        /// </summary>
        public bool IsDefault
        {
            get
            {
                return Equals(new InterchangeContext(Format));
            }
        }

        /// <summary>
        /// Merges the separators of two interchange contexts when the source separator is not empty or null
        /// </summary>
        /// <param name="context">
        /// The context to merge from
        /// </param>
        public void Merge(InterchangeContext context)
        {
            if (context != null)
            {
                // Merge all separators if they are not blank or null
                // All the blank and null separators remain the same
                if (!string.IsNullOrEmpty(context.ComponentDataElementSeparator))
                    ComponentDataElementSeparator = context.ComponentDataElementSeparator;
                if (!string.IsNullOrEmpty(context.DataElementSeparator))
                    DataElementSeparator = context.DataElementSeparator;
                if (!string.IsNullOrEmpty(context.ReleaseIndicator))
                    ReleaseIndicator = context.ReleaseIndicator;
                if (!string.IsNullOrEmpty(context.RepetitionSeparator))
                    RepetitionSeparator = context.RepetitionSeparator;
                if (!string.IsNullOrEmpty(context.SegmentTerminator))
                    SegmentTerminator = context.SegmentTerminator;
            }
        }

        /// <summary>
        /// Validates an interchange context.
        /// Separators must be unique within the interchange context.
        /// </summary>
        /// <returns>If it is valid</returns>
        public bool IsValid(EdiFormats format)
        {
            if(format == EdiFormats.Edifact)
                if (Format != EdiFormats.Edifact) return false;

            if (format == EdiFormats.X12)
                if (Format != EdiFormats.X12) return false;

            var temp = new List<string>();
            if (!string.IsNullOrEmpty(ComponentDataElementSeparator))
                temp.Add(ComponentDataElementSeparator);
            if (!string.IsNullOrEmpty(DataElementSeparator))
                temp.Add(DataElementSeparator);
            if (!string.IsNullOrEmpty(RepetitionSeparator))
                temp.Add(RepetitionSeparator);
            if (!string.IsNullOrEmpty(SegmentTerminator))
                temp.Add(SegmentTerminator);

            var b = temp.GroupBy(t => t).Where(g => g.Count() > 1).Select(v => v.Key).ToList();
            return !b.Any();
        }
        
        /// <summary>
        /// Custom equal
        /// Checks if all separators match
        /// </summary>
        /// <param name="other">
        /// Interchange to compare with
        /// </param>
        /// <returns>
        /// If it is equal, e.g. if all separators match
        /// </returns>
        public bool Equals(InterchangeContext other)
        {
            return (other != null &&
                other.ComponentDataElementSeparator == ComponentDataElementSeparator &&
                other.DataElementSeparator == DataElementSeparator &&
                other.ReleaseIndicator== ReleaseIndicator &&
                other.RepetitionSeparator == RepetitionSeparator &&
                other.SegmentTerminator == SegmentTerminator);
        }

        /// <summary>
        /// Escapes the terminators from a string
        /// </summary>
        /// <param name="line">The string to escape</param>
        /// <returns>The escaped string</returns>
        public string EscapeLine(string line)
        {
            string result = "";

            foreach (var l in line.ToCharArray())
            {
                // If a char is a separator
                if (ContainsTerminator(l))
                {
                    // escape it with the release indicator
                    result = result + ReleaseIndicator + l;
                }
                else
                {
                    result = result + l;
                }
            }

            return result;
        }

        /// <summary>
        /// Checks if a char is a separator
        /// </summary>
        /// <param name="value">The char</param>
        /// <returns>If the char is a separator</returns>
        private bool ContainsTerminator(char value)
        {
            return SegmentTerminator.ToCharArray().Contains(value) ||
                   ComponentDataElementSeparator.ToCharArray().Contains(value) ||
                   DataElementSeparator.ToCharArray().Contains(value) ||
                   RepetitionSeparator.ToCharArray().Contains(value);
        }  
    }
}
