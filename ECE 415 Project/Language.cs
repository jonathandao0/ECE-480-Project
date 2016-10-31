using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_415_Project
{
    class Language
    {
        public double runtime { get; set; }
        public double probability { get; set; }
        public int rank { get; set; }   // Is it necessary?
        public string language { get; set; }
        public string input { get; set; }
    }
}
