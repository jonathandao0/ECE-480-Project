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
          // stopwatch object use to measure the Fast Brain process running time
           Stopwatch stopwatch = new Stopwatch();///Diego->I had to include this because Stopwatch as a static global class was not measuring the right time.
            Language lang = new Language();
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
                   lang = fastBrainProcessEnglish(lang, stopwatch);
                    break;
                case "es":
                    lang = fastBrainProcessSpanish(lang,stopwatch);
                    break;
                case "ru":
                    lang = fastBrainProcessRussian(lang, stopwatch);
                    break;
                default:
                    // Launch Error Window? Loc: I handle this by outputing result = "Undefined" when probability = 0%
                    break;
            }

          
            if (lang.probability < 15)///I changed it to 15 so I was able to easily test the slow BP. Diego
            {
                //stopwatch2 object used to measure the Slow Brain process running time 
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                Thread.Sleep(2999);//This line right here should be eliminated. I'm just including a 2999s delay to simulte the Slow BP. Diego
                
                // Slow Brain processes
                //langs =  SlowBrainProcess.SlowBrainProcess(langs);

                //The slow brain process or function from an object should be put above this code.Diego
                //Measuring SlowBrainProcess run time, in case slow brain  is used. 
                stopwatch2.Stop();
                TimeSpan ts = stopwatch2.Elapsed;

                // TIME should be a double
                double second = ts.Seconds;
                double milisecond = ts.Milliseconds;

                //Time in miliseconds. I decided not to do in milliseconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond;
                //fastBrainRuntime = 0 and slowBrainRuntime=TIME;
                lang.slowBrainRuntime = TIME;
            }

            return lang;
        }

        // Diego: Repeat function for Spanish and Russian
        static Language fastBrainProcessEnglish(Language eng, Stopwatch stopwatch)
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
                //Time in miliseconds. I decided not to do in seconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
                lang.fastBrainRuntime = TIME;
                lang.slowBrainRuntime = 0; //slowBrainRuntime=0 unless it goes into the if statement, in which case the  if (lang.probability < 15) statment will deal with it
                return lang;
            }

           static Language fastBrainProcessRussian(Language eng, Stopwatch stopwatch)
            {
                
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
                //Time in miliseconds. I decided not to do in seconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
                lang.fastBrainRuntime = TIME;
                lang.slowBrainRuntime = 0;//slowBrainRuntime=0 unless it goes into the if statement, in which case the  if (lang.probability < 15) statment will deal with it
                return lang;
            }
           
            static Language fastBrainProcessSpanish(Language eng,Stopwatch stopwatch)
            {
               
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

                //Time in miliseconds. I decided not to do in seconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
                lang.fastBrainRuntime = TIME;
                lang.slowBrainRuntime = 0;//slowBrainRuntime=0 unless it goes into the if statement, in which case the  if (lang.probability < 15) statment will deal with it
                return lang;
            }
        
    }
}

