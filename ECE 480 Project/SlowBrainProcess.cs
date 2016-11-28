using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_480_Project
{
    class SlowBrainProcess
    {
        public static Language[] SlowBrainProcessing(Language[] langs)
        {
            // JY: Add external dictionary access here
            // Access External Dictonary

            // Check for undetected words
            foreach (var lang in langs)
            {
                foreach (var undetectedWord in lang.undetectedWords)
                {


                }
            }
            // Add to personal dictionary

            // recalculate probabilities
            langs[0].probability = 1;// new value

            return langs;
        }
    }
}
