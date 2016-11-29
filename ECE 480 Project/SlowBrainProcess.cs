using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ECE_480_Project
{
    class SlowBrainProcess
    {
        public static Language[] SlowBrainProcessing(Language[] langs)
        {
            // JY: Add external dictionary access here
            // Access External Dictonary

            // Check for undetected words
            int found = 0;
            int total = 0;

            foreach (var lang in langs)
            {
                foreach (var undetectedWord in lang.undetectedWords)
                {
                    StringBuilder glosbeURL = new StringBuilder();
                    glosbeURL.AppendFormat("http://glosbe.com/gapi/translate?from=eng&dest=eng&format=xml&phrase={0}&page=1&pretty=true", undetectedWord);
                    //api for glosbe.com returns an xml file, sends phrase by phrase
                    //from=eng|spa|rus|jpn (allows me to choose which dictionary)
                    string URLString = glosbeURL.ToString();

                    XmlTextReader reader = new XmlTextReader(URLString);

                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Text:
                                {
                                    Console.WriteLine(reader.Value);
                                    if (reader.Value == "meanings") //if a definition is found
                                        found++;

                                    //add to personal dictionary could go here.
                                    break;
                                }

                        }
                    }

                    total = lang.undetectedWords.Length; //only accessible here?

                }
            }

            
           
            // recalculate probabilities
            langs[0].probability = found/total;

            return langs;
        }
    }
}
