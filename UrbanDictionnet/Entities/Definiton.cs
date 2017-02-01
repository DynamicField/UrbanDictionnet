using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanDictionnet.Entities
{
    /// <summary>
    /// A defintion (i had to rename it to definition data because of <see cref="DefinitonData.Definiton"/>)
    /// </summary>
    public class DefinitonData
    {
        /// <summary>
        /// The definition.
        /// </summary>
        public string Definition { get; set; }
        /// <summary>
        /// The number of thumbs up.
        /// </summary>
        public int ThumbsUp { get; set; }
        /// <summary>
        /// The author. (His name)
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// The target word of the definition.
        /// </summary>
        public string Word { get; set; }
        /// <summary>
        /// The definiton id of this definiton.
        /// </summary>
        public int DefId { get; set; }
        /// <summary>
        /// The example for the usage of this word following the definiton.
        /// </summary>
        public string Example { get; set; }
        /// <summary>
        /// The numbers of thumbs down.
        /// </summary>
        public int ThumbsDown { get; set; }       
    }
}
