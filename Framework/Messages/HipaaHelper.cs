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

namespace EdiFabric.Framework.Messages
{
    /// <summary>
    /// Hipaa identifiers.
    /// Identifier = Version + Industry code
    /// </summary>
    class HipaaHelper
    {
        /// <summary>
        /// List of identifiers
        /// </summary>
        static readonly List<string> Identifiers;

        /// <summary>
        /// Static constructor to load the list once
        /// </summary>
        static HipaaHelper()
        {
            Identifiers = new List<string>
            {
                "004010X091",
                "004010X092",
                "004010X093",
                "004010X094",
                "004010X095",
                "004010X096",
                "004010X097",
                "004010X098",
                "004010X061",
                "005010X279",
                "005010X212",
                "005010X214",
                "005010X217",
                "005010X218",
                "005010X220",
                "005010X221",
                "005010X222",
                "005010X223",
                "005010X224",
                "005010X231"
            };
        }

        /// <summary>
        /// Check if the identifier exists
        /// </summary>
        /// <param name="identifier">
        /// The identifier
        /// </param>
        /// <returns>
        /// If it exists or not, e.g. if it is Hipaa
        /// </returns>
        public static bool IsHipaa(string identifier)
        {
            return Identifiers.Contains(identifier);
        }

        /// <summary>
        /// Converts Hipaa industry code into Postfix
        /// Hipaa postfixes are:
        /// P for Professional
        /// I for Institutional
        /// D for Dental
        /// </summary>
        /// <param name="origin"></param>
        /// <returns></returns>
        public static string GetPostfix(string origin)
        {
            switch (origin)
            {
                case "X222":
                case "X098":
                    return "P";
                case "X223":
                case "X096":
                    return "I";
                case "X224":
                case "X097":
                    return "D";
            }

            return null;
        }
    }
}
