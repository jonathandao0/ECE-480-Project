using System.Collections.Generic;
using System.Linq;

namespace Polyglot.Core
{
    public class LanguageDetector
    {
        private const int MaxLength = 4096;
        private const int MaxPenalty = 300;

        private readonly Dictionary<string, Dictionary<string, int>> _availableLanguages;

        public LanguageDetector(Dictionary<string, Dictionary<string, int>> availableLanguages)
        {
            _availableLanguages = availableLanguages;
        }

        public string Detect(string path, out int score)
        {
            score = 0;

            var text = path; //read file

            var ngramBuilder = new NgramBuilder(MaxLength, true);

            var ngrams = ngramBuilder.Get(text); //create an ngram dictionary

            if (ngrams == null)
            {
                return null;
            }

            var shortestDistance = int.MaxValue;

            var probability = 0;

            string lowestScoringLanguage = null;

            foreach (var availableLanguage in _availableLanguages)
            {
                //calculate distance between language and ngrams

                var distance = 0;

                var probabilityHits = 0;

                foreach (var ngram in ngrams)
                {
                    if (availableLanguage.Value.ContainsKey(ngram.Key))
                    {
                        distance += ngram.Value - availableLanguage.Value[ngram.Key];

                        probabilityHits++;
                    }
                    else
                    {
                        distance += MaxPenalty;
                    }

                    if (distance > shortestDistance)
                    {
                        break;
                    }
                }

                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    lowestScoringLanguage = availableLanguage.Key;
                    probability = probabilityHits;
                }
            }

            if (probability > 30)
                probability = 100;
            else if (probability < 30)
                probability = 80;

            score = probability;

            return lowestScoringLanguage;
        }
    }
}