using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace UrbanDictionnet.Entities
{
    /// <summary>
    /// A word definition.
    /// </summary>
    [SuppressMessage("ReSharper", "CollectionNeverUpdated.Global")]
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class WordDefine : IEnumerable<DefinitonData>
    {
        /// <summary>
        /// Refers to <see cref="List"/>
        /// </summary>
        /// <param name="index">The index</param>
        /// <returns>A <see cref="DefinitonData"/> from <see cref="List"/></returns>
        public DefinitonData this[int index]
        {
            get { return List[index]; }
            set { List[index] = value; }
        }
        /// <summary>
        /// The type, can be either "exact", or "NoResults"
        /// </summary>
        public ResultType ResultType { get; set; }
        /// <summary>
        /// The list of tags
        /// </summary>
        public List<string> Tags { get; set; }
        /// <summary>
        /// The definitions. Yes it's called List but i don't want to add a reference to Newtonsoft.JSON and to RestSharp.Newtonsoft.JSON either so yeah.
        /// </summary>        
        public List<DefinitonData> List { get; set; }
        /// <summary>
        /// All the sounds links.
        /// </summary>
        public List<string> Sounds { get; set; }
        /// <summary>
        /// Gets the enumerator of <see cref="List"/>
        /// </summary>
        /// <returns>An enumerator with generic type <see cref="DefinitonData"/></returns>
        public IEnumerator<DefinitonData> GetEnumerator()
        {
            return List.GetEnumerator();
        }
        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>An enumerator</returns>
        [ExcludeFromCodeCoverage] // It is a private function.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) List).GetEnumerator();
        }
    }
}
