using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_480_Project
{
    class EnglishFBP:ILangProcess
    {
        public Language lang;

        public EnglishFBP(string inputString)
        {
            lang.inputString = inputString;

        }

        void FastBrainProcess(){

            // Improve probability based on dictionary
            // Mayeli: implement file I/O here, as well as an algorithm to split a string into its individual words and place them into an array
            string[] words, undetectedWords;
            int totalWords = 0, detectedWords = 0;
            // get each word from the input string (A 'word' will be a cluster of chars that are seperated by spaces, punctuation, etc.

            // for each word, read from the dictionary text file to see if there is a match
            foreach (var word in words)
            {
                // count number of detected words & place them into an array
                if(){
                    detectedWords++;
                }
                // count number of total words
                totalWords++;
            }
            // generate probability
            dProb = detectedWords / totalWords;
            
            lang.undetectedWords = undetectedWords;

            lang.probability = nGramProb * 0.9 + dProb * 0.1;
        }

        public Language Lang{
            get{
                return lang;
            }
        }
    }
}
