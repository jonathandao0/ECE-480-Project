using Polyglot.Core;
using System;
using System.Collections.Generic;
//using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace ECE_480_Project
{
    class MainProgramCode
    {
        //static Task task;///Diego->I added this
        //static Language[] langs = new Language[3];            //Diego->I uncomented this
        static ILangProcess[] processes = new ILangProcess[3]; //Diego->I uncomented this
        static string languageCode;///Diego->I added this global variable previously found in the main function.
        const string knownLanguagesFile = @"Languages\known_languages.txt";
        
        static Stopwatch stopwatch = new Stopwatch();
        public static Language MainProgram(string stringInput)//, out string ID, out double probability)
        {
            Language lang = new Language();
           // ILangProcess[] processes = new ILangProcess[3];

            // Fast Brain Processes
            stopwatch.Start();
            var learner = new LanguageLearner();
            var knownLanguages = learner.Remember(knownLanguagesFile);
            var detector = new LanguageDetector(knownLanguages);
            int score;
            var languageCode = detector.Detect(stringInput, out score);
            lang.inputString = stringInput;
            lang.languageType = languageCode;
            lang.probability = score;

            // Kevin: Make sure all data is passed through the lang class properly
            switch(languageCode)
            {
                case "en":
                    lang = fastBrainProcessEnglish(lang);
                    break;
                case "es":
                    //lang = fastBrainProcessSpanish(lang);
                    break;
                case "ru":
                    //lang = fastBrainProcessRussian(lang);
                    break;
                default:
                    // Launch Error Window? Loc: I handle this by outputing result = "Undefined" when probability = 0%
                    break;
            }

            if (lang.probability < 0.5)
            {
                // Slow Brain processes
                //langs =  SlowBrainProcess.SlowBrainProcess(langs);
            }
            return lang;
        }

        // Diego: Repeat function for Spanish and Russian
        static Language fastBrainProcessEnglish(Language eng)
        {
            Task<Language> task;
            Language lang;
            task = Task<Language>.Factory.StartNew(() =>
            {
                var process = new EnglishFBP(eng);
                return process.Lang;
            });
            lang = task.Result;
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            // TIME should be a double
            var second = ts.Seconds;
            var milisecond = ts.Milliseconds;
            double TIME = second + (milisecond / 1000);
            //Time in seconds with a milisecond precission. 
            lang.fastBrainRuntime = TIME;
            return lang;
        }

        //fastBrainProcessSpanish

        //fastBrainProcessRussian

        /*
        private static void ThreadingProcess(string stringInput)
        {                                                   
            /////This is kevin's code put into a function. If I am not mistaken, this function is identifying the language in the string.
            ///There are some other operations which I decided to include into the function
            ///I also converted into global variables some variables that previously were local(
            var learner = new LanguageLearner();
            var knownLanguages = learner.Remember(knownLanguagesFile);
            var detector = new LanguageDetector(knownLanguages);
            int score;
            languageCode = detector.Detect(stringInput, out score);
            switch (languageCode)
            {
                case "en":
                    processes[0] = new EnglishFBP(stringInput, score);
                    break;
                default:
                    break;

            }
        }
        */


        /*
        ///The following two functions are just to make the above function work asyncrhonoulsy. It would be of some use if we were 
        ///working with several processes at the same time. However, it seems that we are only working with one: identifying one language.
        private static Task ThreadingProcessAsync(string stringInput)
        {
            var task = Task.Factory.StartNew(() => ThreadingProcess(stringInput));
            return task; ;
        }

        private static async void CallThreadingProcess(string stringInput)
        {
            await ThreadingProcessAsync(stringInput);
        }





        /*private static Task waitingAsync(int id)
        {
            task[id] = Task.Factory.StartNew(() => waiting(id));
            return task[id];
        }
        private static async void Callwait(int id)
        {
            await waitingAsync(id);
        }
    }*/
    }
}

