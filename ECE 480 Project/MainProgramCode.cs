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
        const string knownLanguagesFile = @"Languages\known_languages.txt";
                 
        public static Language MainProgram(string stringInput)
        {
            Stopwatch stopwatch = new Stopwatch();
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
            lang.nGramProbability = score;

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
                case "nl":
                    fastBrainProcess(lang, stopwatch);
                   break;
                case "bg":
                   fastBrainProcess(lang, stopwatch);
                   break;
                case "de":
                   fastBrainProcess(lang, stopwatch);
                   break;
                   
                default:
                    // Launch Error Window? Loc: I handle this by outputing result = "Undefined" when probability = 0%
                    break;
            }
<<<<<<< HEAD

            //The slow Brain process is never used if it includes bulgarian, german, and dutch
            if ((lang.probability < 15) && (languageCode != "bg") && (languageCode != "de") && (languageCode != "nl"))///I changed it to 15 so I was able to easily test the slow BP. Diego
            {
                //stopwatch2 object used to measure the Slow Brain process running time 
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                Thread.Sleep(2999);//This line right here should be eliminated. I'm just including a 2999s delay to simulte the Slow BP. Diego
                //The slow brain process or function should be put below this code.Diego

=======
          
            if (lang.probability < 50){
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                //Thread.Sleep(2999);//This line right here should be eliminated. I'm just including a 2999s delay to simulte the Slow BP. Diego
                
>>>>>>> be95c7c28939d1e9ce574ea4ef39d6fdcae8aefb
                // Slow Brain processes
                lang =  SlowBrainProcess.SlowBrainProcessing(lang);

<<<<<<< HEAD
                //The slow brain process or function should be put above this code.Diego
                //Measuring SlowBrainProcess run time, in case slow brain  is used. 
=======
>>>>>>> be95c7c28939d1e9ce574ea4ef39d6fdcae8aefb
                stopwatch2.Stop();
                TimeSpan ts = stopwatch2.Elapsed;

                double second = ts.Seconds;
                double milisecond = ts.Milliseconds;

                double TIME = second * 1000 + milisecond;
                lang.slowBrainRuntime = TIME;
            }

            return lang;
        }

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

            var second = ts.Seconds;
            var milisecond = ts.Milliseconds;
            double TIME = second * 1000 + milisecond; 
            lang.fastBrainRuntime = TIME;

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

            var second = ts.Seconds;
            var milisecond = ts.Milliseconds;
            double TIME = second * 1000 + milisecond; 
            lang.fastBrainRuntime = TIME;

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

            var second = ts.Seconds;
            var milisecond = ts.Milliseconds;

<<<<<<< HEAD
                //Time in miliseconds. I decided not to do in seconds because when dividing 
                //milisecond by 1000 then the result was only giving zeroes.
                double TIME = second * 1000 + milisecond; 
                lang.fastBrainRuntime = TIME;
                lang.slowBrainRuntime = 0;//slowBrainRuntime=0 unless it goes into the if statement, in which case the  if (lang.probability < 15) statment will deal with it
                return lang;
            }
            private static void fastBrainProcess( Language lang, Stopwatch stopwatch)
            {
                
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
                
            }
=======
            double TIME = second * 1000 + milisecond; 
            lang.fastBrainRuntime = TIME;
            
            return lang;
        }
>>>>>>> be95c7c28939d1e9ce574ea4ef39d6fdcae8aefb
    }
}

