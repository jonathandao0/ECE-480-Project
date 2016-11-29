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
       // static string languageCode;///Diego->I added this global variable previously found in the main function.
        const string knownLanguagesFile = @"Languages\known_languages.txt";
        
         
        public static Language MainProgram(string stringInput)//, out string ID, out double probability)
        {
           Stopwatch stopwatch = new Stopwatch();///Diebo->I had to include this because Stopwatch as a static global class was not measuring the right time.
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
                 //   lang = fastBrainProcessEnglish(lang);
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

          
            if (lang.probability < 15)///I changed it to 15 so I was able to easily test the slow BP. Diego
            {
                Thread.Sleep(2999);//This line right here should be eliminated. I'm just including a 10s delay to simulte the Slow BP. Diego
                
                // Slow Brain processes
                //langs =  SlowBrainProcess.SlowBrainProcess(langs);

                //The slow brain process or function from an object should be put above this code.Diego
                //Measuring SlowBrainProcess run time, in case slow brain  is used. 
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;

                // TIME should be a double
                double second = ts.Seconds;
                double milisecond = ts.Milliseconds;

                //Time in miliseconds. I decided not to do in milliseconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond;
                //fastBrainRuntime = 0 and slowBrainRuntime=TIME;
                lang.fastBrainRuntime = 0;
                lang.slowBrainRuntime = TIME;
            }

            // This else statement will measure the time in case the slow brain is not used
            else
            {
               
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            // TIME should be a double
            double second = ts.Seconds;
            double milisecond = ts.Milliseconds;

            //Time in miliseconds. I decided not to do in milliseconds because when dividing 
            //milisecond by 1000 then the result was only giving zeroes.
            double TIME = second * 1000 + milisecond;
            //fastBrainRuntime = TIME and slowBrainRuntime=0;
            lang.fastBrainRuntime = TIME;
            lang.slowBrainRuntime = 0;
            }
          
            return lang;
        }

        // Diego: Repeat function for Spanish and Russian
           static Language fastBrainProcessEnglish(Language eng)
            {
                Stopwatch stopwatch = new Stopwatch();
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
                //Time in miliseconds. I decided not to do in milliseconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
                lang.fastBrainRuntime = TIME;
                return lang;
            }

            static Language fastBrainProcessRussian(Language eng)
            {
                Stopwatch stopwatch = new Stopwatch();
                Task<Language> task;
                Language lang;
                task = Task<Language>.Factory.StartNew(() =>
                {
                    var process = new RussianFBP(eng);
                    return process.Lang;
                });
                lang = task.Result;
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;

                // TIME should be a double
                var second = ts.Seconds;
                var milisecond = ts.Milliseconds;
                //Time in miliseconds. I decided not to do in milliseconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
                lang.fastBrainRuntime = TIME;
                return lang;
            }
            //Hey jonathan, I know this demonstrates where our project could go into the future, by 
            //applying different threads to look for the different languages simultaneously, but if I am
            //not mistaken, I think this should by applied in the polyglot code, because the 
            //main function does not use the FB processes. It only receives the information from the FB processes or the polyglot code.
            //In that case, we could keep this function in case we have time to explain, but I'll just implement this code up above
            
            static Language fastBrainProcessSpanish(Language eng)
            {
                Stopwatch stopwatch = new Stopwatch();
                Task<Language> task;
                Language lang;
                task = Task<Language>.Factory.StartNew(() =>
                {
                    var process = new SpanishFBP(eng);
                    return process.Lang;
                });
                lang = task.Result;
                stopwatch.Stop();
                TimeSpan ts = stopwatch.Elapsed;

                // TIME should be a double
                var second = ts.Seconds;
                var milisecond = ts.Milliseconds;

                //Time in miliseconds. I decided not to do in milliseconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
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

