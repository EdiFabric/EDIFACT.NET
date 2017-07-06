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
using System.Xml.Serialization;

namespace EdiFabric.Core.Model.Edi
{
    /// <summary>
    /// The base EDI message.
    /// </summary>
    public class EdiMessage : EdiItem
    {
        /// <summary>
        /// The message ID.
        /// </summary>
        [XmlIgnore]
        public string Name { get; private set; }
        /// <summary>
        /// The message version (derived from the group if not explicitly set in the message).
        /// </summary>
        [XmlIgnore]
        public string Version { get; private set; }
        /// <summary>
        /// The message format (X12 or Edifact or other).
        /// </summary>
        [XmlIgnore]
        public string Format { get; private set; }
        /// <summary>
        /// Message part index.
        /// </summary>
        [XmlIgnore]
        public int MessagePart { get; set; }

        private string _controlNumber;
        /// <summary>
        /// The message control number.
        /// </summary>
        [XmlIgnore]
        public string ControlNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_controlNumber))
                    _controlNumber = GetControlNumber();
                
                return _controlNumber;
            }
            set { _controlNumber = value; }
        }

        /// <summary>
        /// If it was parsed in full.
        /// </summary>
        [XmlIgnore]
        public bool HasErrors
        {
            get { return ErrorContext != null && ErrorContext.HasErrors; }
        }

        /// <summary>
        /// Message error context.
        /// </summary>
        [XmlIgnore]
        public MessageErrorContext ErrorContext { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdiMessage"/> class.
        /// </summary>
        /// <exception cref="Exception">Throws exception if any of the EDI attributes is missing.</exception>
        public EdiMessage()
        {
            var type = this.GetStandardType();
            var msgAttr = type.GetCustomAttribute<MessageAttribute>();
            if (msgAttr == null)
                throw new Exception(string.Format("{0} was not found in {1} .", typeof (MessageAttribute).Name,
                    type.FullName));

            Format = msgAttr.Format;
            if (Format == null) throw new Exception("Format is null");
            Version = msgAttr.Version;
            if (Version == null) throw new Exception("Version is null");
            Name = msgAttr.Id;
            if (Name == null) throw new Exception("Name is null");
            MessagePart = 0;
        }

        /// <summary>
        /// Validates a message according to its validation attributes.
        /// </summary>
        /// <param name="result">The resulting message context.</param>
        /// <param name="skipTrailer">Whether to validate the trailer. Skip when validating custom created messages.</param>
        /// <returns>Whether the message is valid or not. If not valid then the message error context will contain the reasons.</returns>
        public bool IsValid(out MessageErrorContext result, bool skipTrailer = false)
        {
            result = new MessageErrorContext(Name, ControlNumber, MessagePart, null);

            int segmentsNum;
            result.AddRange(this.Validate(out segmentsNum));
        
            if (!skipTrailer)
                foreach (var errorCode in ValidateStructure(segmentsNum))
                    result.Add(errorCode);

            if (HasErrors)
            {
                result.AddRange(ErrorContext.Errors);
                result.AddRange(ErrorContext.Codes);
            }

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
            var controlNumber = ControlNumber;

            if (string.IsNullOrEmpty(controlNumber))
            {
                result.Add(MessageErrorCode.MissingOrInvalidControlNumber);
                return result;
            }

            var trailerProperty =
                this.GetStandardType()
                    .GetProperties()
                    .Where(p => p.GetStandardType().GetCustomAttribute<SegmentAttribute>() != null)
                    .SingleOrDefault(p => p.GetStandardType().GetCustomAttribute<SegmentAttribute>().Id == tag);

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
                trailer.GetStandardType().GetProperties().Sort().Select(property => property.GetValue(trailer)).ToList();

            if(values.Count != 2)
                return new Tuple<int, string>(-1, null);

            var sn = values[0] as string;
            var cn = values[1] as string;

            int trailerSegmentsNumber;
            if (!Int32.TryParse(sn, out trailerSegmentsNumber))
                return new Tuple<int, string>(-1, cn);

            return new Tuple<int, string>(trailerSegmentsNumber, cn);
        }

        private string GetControlNumber()
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
                this.GetStandardType()
                    .GetProperties()
                    .Where(p => p.GetStandardType().GetCustomAttribute<SegmentAttribute>() != null)
                    .SingleOrDefault(p => p.GetStandardType().GetCustomAttribute<SegmentAttribute>().Id == tag);

            if (headerProperty == null)
                return null;

            var headerValue = headerProperty.GetValue(this);
            var cnProperty =
                headerValue.GetStandardType()
                    .GetProperties()
                    .SingleOrDefault(p => p.GetCustomAttribute<PosAttribute>().Pos == position);

            if (cnProperty == null)
                return null;

            return cnProperty.GetValue(headerValue) as string;
        }       
    }
}
