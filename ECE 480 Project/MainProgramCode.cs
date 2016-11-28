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
        public static Language[] MainProgram(string stringInput, out string ID, out double probability)
        {
            Language[] langs = new Language[3];
            ILangProcess[] processes = new ILangProcess[3];
           
            // Fast Brain Process

            // Kevin: I'm a bit confused, I imangined this part being done for each FBP (e.g. english accesses knownLanguages for en to get the n-grams to determine the score), instead of done here for each language.
            // 

            var learner = new LanguageLearner();
            var knownLanguages = learner.Remember(knownLanguagesFile);
            var detector = new LanguageDetector(knownLanguages);
            int score;
            var languageCode = detector.Detect(stringInput, out score);

            processes[0] = new EnglishFBP(stringInput);
              // each FBP should inherant ILangProcess interface
            switch(languageCode)
            {
                case "en": 
                    processes[0] = new EnglishFBP(stringInput,score);
                    break;
                default:
                    break;

            }
            
            // Start threading here
            langs[0] = fastBrainProcessEnglish(stringInput);
            //processes[0] = new EnglishFBP(stringInput);
            //processes[1] = new EnglishFBP(stringInput);
            //processes[2] = new EnglishFBP(stringInput);

            ///Diego added this part of the code starting here
            /*
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CallThreadingProcess(stringInput);
            Task.WaitAll(task);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            var second = ts.Seconds;
            var milisecond = ts.Milliseconds;
            var TIME = second + milisecond * 1000;//Time in seconds with a milisecond precission. 
            */
            //langs[0] = processes[0].Lang;
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

            ID = languageCode;
            probability = langs[0].probability;
            return langs;
        }

        static Language fastBrainProcessEnglish(string stringInput)
        {
            Task<Language> task;
            Language lang;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            task = Task<Language>.Factory.StartNew(() =>
            {
                var process = new EnglishFBP(stringInput);
                return process.Lang;
            });
            lang = task.Result;
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            // TIME should be a double
            var second = ts.Seconds;
            var milisecond = ts.Milliseconds;
            var TIME = second + milisecond * 1000;//Time in seconds with a milisecond precission. 
            lang.fastBrainRuntime = TIME;
            return lang;
        }
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

