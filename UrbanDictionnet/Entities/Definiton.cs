using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanDictionnet.Entities
{
    public class Definiton
    {
        public Definiton() { }
        public string DefinitonString { get; set; }
        public int ThumbsUp { get; set; }
        public string Author { get; set; }
        public string Word { get; set; }
        public int DefId { get; set; }
        public string Example { get; set; }
        public int ThumbsDown { get; set; }       
    }
}
