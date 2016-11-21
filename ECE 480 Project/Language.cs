using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_480_Project
{
    class Language
    {
        public double fastBrainRuntime { get; set; }
        public double slowBrainRuntime { get; set; }
        public double probability { get; set; }
        public int rank { get; set; }
        public string languageType { get; set; }
        public string inputString { get; set; }
        public string[] undetectedWords { get; set; }
    }
}
