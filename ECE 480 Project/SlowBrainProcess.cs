﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ECE_480_Project
{
    class SlowBrainProcess
    {
        public static Language SlowBrainProcessing(Language lang)
        {
            //checks undetected words in external dictionary
            int found = 0;
            int total = 0;
            if (lang.undetectedWords != null) // handle cases with one detected word
            {
                string langType = "eng";
                switch (lang.languageType)
                {
                    case "en":
                        langType = "eng";
                        break;
                    case "es":
                        langType = "spa";
                        break;
                    case "ru":
                        langType = "rus";
                        break;
                    default:
                        langType = "eng";
                        break;
                }
                foreach (var undetectedWord in lang.undetectedWords)
                {
                    StringBuilder glosbeURL = new StringBuilder();
                    glosbeURL.AppendFormat("http://glosbe.com/gapi/translate?from={0}&dest=eng&format=xml&phrase={1}&page=1&pretty=true", langType, undetectedWord);
         
                    string URLString = glosbeURL.ToString();

                    XmlTextReader reader = new XmlTextReader(URLString); //returns as an XML file

                    while (reader.Read())
                    {
                        switch (reader.NodeType) //reads phrase by phrase
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
                // recalculate probabilities
                //lang.probability = lang.probability + found / total;
            }
            
       
            return lang;
        }
    }
}
