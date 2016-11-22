using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvanAkcheurov.NTextCat.Lib;

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
            var filepath = "C:\\Users\\jonat\\Documents\\Projects\\ECE 480 Project\\ECE 480 Project\\Core14.profile.xml"; // Change this depending on machine, need to improve this so you don't have to change it
            var factory = new RankedLanguageIdentifierFactory();
            var loadNGrams = factory.Load(filepath);
            var id = loadNGrams.Identify(lang.inputString);

            double nGramProb = 0;
            double dProb = 0;


            // Note: The following formula/algorithm may change at a later date
            // Kevin: Implement Polyglot here:
            int count = 1;
            foreach (var iso in id){
                if (iso.Item1.Iso639_3 == "eng"){
                    if (iso.Item2 > 3990)
                        nGramProb = 0;
                    else if (iso.Item2 < 3600)
                        nGramProb = 1;
                    else
                        nGramProb = (4000 - iso.Item2) / 390;

                    lang.rank = count;
                }
                count++;
            }

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
