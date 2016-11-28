using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ECE_480_Project
{
    class AdminModeInitialize
    {

        public static string[] intitalizeEnglishNGram(){
            string[] nGramArray;
            
            // Mayeli: have this only read the line containing English n-Grams
            string nGrams = File.ReadAllText(@"Languages\known_languages.txt").ToUpper(); // read contents of diccionary
            nGramArray = nGrams.Split(' '); // Add words of dictionary to array
            return nGramArray;
        }

        public static string[] intitalizeEnglishDictionary(){
            string[] wordArray;
            string dictionary = File.ReadAllText(@"Languages\English\EnglishDictionary.txt").ToUpper(); // read contents of diccionary
            wordArray = dictionary.Split(' '); // Add words of dictionary to array
            return wordArray;
        }

        // Mayeli: repeat for all other languages
        public static string[] intitalizeSpanishNGram() { }
        public static string[] intitalizeSpanishDictionary() { }
        public static string[] intitalizeRussianNGram() { }
        public static string[] intitalizeRussianDictionary() { }
    }
}
