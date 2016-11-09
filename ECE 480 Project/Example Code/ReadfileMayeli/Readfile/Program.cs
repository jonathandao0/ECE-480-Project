using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // StreamRteader to read file and closing it
                using (StreamReader sr = new StreamReader("c:/learningtext.txt"))
                {
                    string line;

                    // Read and display lines from the file until the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {

                // Message displaying if something go wrong
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

