using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ECE_480_Project
{
    public class EnglishFBP : ILangProcess
    {
        public Language lang = new Language();
        public EnglishFBP(Language eng)
        {
            lang = eng;
            lang.inputString = eng.inputString.ToUpper();
            FastBrainProcess();
        }

        public void FastBrainProcess()
        {
            // Improve probability based on dictionary
            // Mayeli: implement file I/O here, as well as an algorithm to split a string into its individual words and place them into an array
            string[] words, dictArray;
            string[] undetectedWords = new string[100];

            int detectedWords = 0, totalWords = 0, i = 0;
            // get each word from the input string (A 'word' will be a cluster of chars that are seperated by spaces, punctuation, etc.
            string dictionary = File.ReadAllText(@"Languages\English\EnglishDictionary.txt").ToUpper(); // read contents of diccionary
            dictArray = dictionary.Split(' '); // Add words of dictionary to array
            words = lang.inputString.Split(' '); // Add input words to array

            // for each word, read from the dictionary text file to see if there is a match
            foreach (var word in words)
            {
                foreach (var wordd in dictArray)
                {
                    if (word == wordd)
                    {
                        // count number of detected words & place them into an array
                        detectedWords++;
                    }
                    else
                        undetectedWords[i++] = word;
                }
                // count number of total words
                totalWords = words.Length;
            }
            // generate probability
            double dProb = detectedWords / totalWords;

            lang.undetectedWords = undetectedWords;

            lang.probability = lang.probability + (100 - lang.probability) * dProb;
            lang.fBPProbability = lang.probability;
        }

        public Language Lang
        {
            get
            {
                return lang;
            }
        }
    }
}
