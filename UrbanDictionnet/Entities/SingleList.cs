using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanDictionnet
{
    /// <summary>
    /// A single list class, espically used for deserializing a random word request
    /// </summary>
    /// <typeparam name="T">The type used in the list.</typeparam>
    internal class SingleList<T> where T : new()
    {
        /// <summary>
        /// The list of objects given.
        /// </summary>
        public List<T> List { get; set; }
    }
}
