using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double percentage, wordsFound = 0;
            string line;
            // This array contains the most common words in English
            string[] English = { "ABOUT", "ALL", "AN", "AND", "AS", "AT", "BE", "BUT", "CAN", "DAY", "DO", "DOG", "EXAMPLE", "FOR", "FROM",
                "GET", "GIVE", "GO",
                "HAPPY", "HAVE", "HE", "HER", "I", "IF", "IN", "IS", "LIKE",
                "MAKE", "ME", "MINE", "MOST", "NOT", "OF", "ON", "ONE", "OR", "OUT", "SAY", "SHE", "SO",
                "TEST", "THAT", "THE", "THEIR", "THERE", "THEY", "THIS", "TIME", "TO", "UP", "US",
                "WE", "WHEN", "WHERE", "WHICH", "WHO", "WILL", "WITH", "WOULD", "YOU" };

            // Allow user to type string
            Console.Write("Enter text: ");
            line = Console.ReadLine().ToUpper();
            string[] words = line.Split(' ');

            // Check if letters belong to English alphabet
            if (Regex.IsMatch(line, "^[a-zA-Z ]+$"))
            {
                // Check number of words in English
                Console.WriteLine("All characters belong to the English alphabet");
                for (int i = 0; i < words.Length; i++)
                {

                    for (int j = 0; j < English.Length; j++)
                    {
                        if (words[i].Equals(English[j]))
                        {
                            wordsFound++;
                        }
                    }
                }
                // Find the percentage of words found in dictionary
                percentage = (wordsFound / words.Length) * 100;
                Console.WriteLine(wordsFound + " out of " + words.Length +
                    " words found in English dictionary. It is " + percentage + "% English");
            }

            // If not all character belong to English alphabet display message
            else
            {
                Console.WriteLine("Not all characters belong to the English alphabet");
            }
        }
    }
}

