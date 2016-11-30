using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_480_Project
{
    public class Language
    {
        [System.ComponentModel.DefaultValue(0)]
        public double fastBrainRuntime { get; set; }
        [System.ComponentModel.DefaultValue(0)]
        public double slowBrainRuntime { get; set; }
        [System.ComponentModel.DefaultValue(0)]
        public double probability { get; set; }
        [System.ComponentModel.DefaultValue(0)]
        public double nGramProbability { get; set; }
        [System.ComponentModel.DefaultValue(0)]
        public double fBPProbability { get; set; }
        public int rank { get; set; }
        public string languageType { get; set; }
        public string inputString { get; set; }
        public string[] undetectedWords { get; set; }
    }
}
