using System.Collections.Generic;

namespace UrbanDictionnet.Entities
{
    public class WordDefine
    {
        public ResultType ResultType { get; set; }
        public List<string> Tags { get; set; }
        public List<Definiton> List { get; set; }
        public List<string> Sounds { get; set; }
        public WordDefine() { }
    }
}
