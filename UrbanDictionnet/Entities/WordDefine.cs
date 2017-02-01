using System.Collections.Generic;

namespace UrbanDictionnet.Entities
{
    public class WordDefine
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
        /// The definitions. Yes it's called list but i don't want to add a reference to Newtonsoft.JSON and to RestSharp.Newtonsoft.JSON either so yeah.
        /// </summary>
        public List<DefinitonData> List { get; set; }
        /// <summary>
        /// All the sounds links.
        /// </summary>
        public List<string> Sounds { get; set; }
    }
}
