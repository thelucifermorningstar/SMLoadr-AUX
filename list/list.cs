using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMLoader.list
{
   public class Artist
    {
        public string name { get; set; }
        public string link { get; set; }
        public string pic { get; set; }
    }

    public class Album
    {
        public string title { get; set; }
        public string link { get; set; }
        public string pic { get; set; }
        public string artist { get; set; }
        public string tracks { get; set; }
    }
    
    public class Track
    {
        public string title { get; set;}
        public string link { get; set; }
        public string mp3 { get; set; }
    }
}
