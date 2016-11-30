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
          
            if (lang.probability < 0.15){
                Stopwatch stopwatch2 = new Stopwatch();
                stopwatch2.Start();
                //Thread.Sleep(2999);//This line right here should be eliminated. I'm just including a 2999s delay to simulte the Slow BP. Diego
                
                // Slow Brain processes
                lang =  SlowBrainProcess.SlowBrainProcessing(lang);

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

            double TIME = second * 1000 + milisecond; 
            lang.fastBrainRuntime = TIME;
            
            return lang;
        }
    }
}

