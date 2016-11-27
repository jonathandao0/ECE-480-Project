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

        const string knownLanguagesFile = @"Languages\known_languages.txt";
        public static Language[] MainProgram(string stringInput)
        {
            Language[] langs = new Language[3];
            ILangProcess[] processes = new ILangProcess[3];
            // Fast Brain Process
            var learner = new LanguageLearner();
            var knownLanguages = learner.Remember(knownLanguagesFile);
            var detector = new LanguageDetector(knownLanguages);
            int score;
            var languageCode = detector.Detect(stringInput, out score);

            // each FBP should inherant ILangProcess interface
            switch(languageCode)
            {
                case "en": 
                    processes[0] = new EnglishFBP(stringInput,score);
                    break;
                default:
                    break;

            }

            //processes[0] = new EnglishFBP(stringInput);
            //processes[1] = new EnglishFBP(stringInput);
            //processes[2] = new EnglishFBP(stringInput);

            // Diego: Thread all processes here for FBP & add runtime start/stops

            // return results here
            langs[0] = processes[0].Lang;

            int count = 0;
            foreach (var lang in langs)
            {
                if (langs[0].probability < 50)
                    count++;

                if (count > 0)
                {
                    // Slow Brain processes
                }
            }


            return langs;
        }
    }
}

