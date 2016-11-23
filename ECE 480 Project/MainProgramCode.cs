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

        const string knownLanguagesFile = @"C:\Users\Admin\Desktop\detect\known_languages.txt"; // Change this later
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

            processes[0] = new EnglishFBP(stringInput);
            //processes[1] = new EnglishFBP(stringInput);
            //processes[2] = new EnglishFBP(stringInput);

            // Diego: Thread all processes here for FBP & add runtime start/stops

            // return results here
            for (int i = 0; i < 3; i++)
                langs[i] = processes[i].Lang;

            int count = 0;
            foreach (var lang in langs)
            {
                if (lang.probability < 50)
                    count++;

                if (score > 0)
                {
                    // Slow Brain processes
                }
            }


            return langs;
        }
    }
}

