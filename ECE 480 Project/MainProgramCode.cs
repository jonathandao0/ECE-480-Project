using Polyglot.Core;
using System;
using System.Collections.Generic;
//using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ECE_480_Project
{
    class MainProgramCode
    {
        //static Language[] langs = new Language[3];
        //static ILangProcess[] processes = new ILangProcess[3];
        private const int MaxLength = 4096;
        private const int MaxPenalty = 300;

        private readonly Dictionary<string, Dictionary<string, int>> _availableLanguages;

        public MainProgramCode(Dictionary<string, Dictionary<string, int>> availableLanguages)
        {
            _availableLanguages = availableLanguages;
        }

        const string knownLanguagesFile = @"C:\Users\Admin\Desktop\detect\known_languages.txt"; // Change this later
        public static Language[] MainProgramCode(string stringInput)
        {
            // Fast Brain Process
            var learner = new LanguageLearner();
            var knownLanguages = learner.Remember(knownLanguagesFile);
            var detector = new LanguageDetector(knownLanguages);
            int score;
            var languageCode = detector.Detect(stringInput, out score);

            // each FBP should inherant ILangProcess interface
            //Detect(stringInput, knownLanguagesFile);
            //processes[0] = new EnglishFBP(stringInput);
            //processes[1] = new EnglishFBP(stringInput);
            //processes[2] = new EnglishFBP(stringInput);

            // Diego: Thread all processes here for FBP & add runtime start/stops

            // return results here

            if (score < 40)   // If porbability is less than 40% run the slow brain process
            {
                // Slow Brain processes
            }


            //return langs;
        }
    }
}

