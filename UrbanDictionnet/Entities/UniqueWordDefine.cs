using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace UrbanDictionnet
{
    public class UniqueWordDefine
    {
        /// <summary>
        /// The type, can be either "exact", or "NoResults"
        /// </summary>
        public ResultType ResultType { get; set; }
        /// <summary>
        /// The list of tags
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// The definition list.
        /// </summary>        
        [Obsolete("Prefer definition.")]
        public List<DefinitonData> List { [ExcludeFromCodeCoverage] get; internal set; }
        /// <summary>
        /// The definition
        /// </summary>
#pragma warning disable 618
        public DefinitonData Definition => List[0];
#pragma warning restore 618
    }
}