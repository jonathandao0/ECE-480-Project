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
            string nGrams = File.ReadLines(@"Languages\known_languages.txt").First().ToUpper(); // read contents of diccionary
            nGramArray = nGrams.Split(' '); // Add words of dictionary to array
            return nGramArray;
        }

        public static string[] intitalizeEnglishDictionary(){
            string[] wordArray;
            string dictionary = File.ReadAllText(@"Languages\English\EnglishDictionary.txt").ToUpper(); // read contents of diccionary
            wordArray = dictionary.Split(' '); // Add words of dictionary to array
            return wordArray;
        }

        public static string[] intitalizeSpanishNGram() {
          string[] nGramArray;

          //This only read the line containing Spanish n-Grams
          string nGrams = File.ReadLines(@"Languages\known_languages.txt").Skip(2).Take(1).First().ToUpper(); // read contents of diccionary
          nGramArray = nGrams.Split(' '); // Add words of dictionary to array
          return nGramArray;
         }
        public static string[] intitalizeSpanishDictionary() {
          string[] wordArray;
          string dictionary = File.ReadAllText(@"Languages\English\SpanishDictionary.txt").ToUpper(); // read contents of diccionary
          wordArray = dictionary.Split(' '); // Add words of dictionary to array
          return wordArray;
         }
        public static string[] intitalizeRussianNGram() {
          string[] nGramArray;

          //This only read the line containing Russian n-Grams
          string nGrams = File.ReadLines(@"Languages\known_languages.txt").Skip(8).Take(1).First().ToUpper(); // read contents of diccionary
          nGramArray = nGrams.Split(' '); // Add words of dictionary to array
          return nGramArray;
         }
        public static string[] intitalizeRussianDictionary() {
          string[] wordArray;
          string dictionary = File.ReadAllText(@"Languages\English\RussianDictionary.txt").ToUpper(); // read contents of diccionary
          wordArray = dictionary.Split(' '); // Add words of dictionary to array
          return wordArray;
         }
    }
}
