using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_480_Project
{
    class MainProgramCode
    {
        static Language[] langs = new Language[3];
        static ILangProcess[] processes = new ILangProcess[3];

        public static Language[] MainProgramCode(string stringInput)
        {
            // Fast Brain Process
                // each FBP should inherant ILangProcess interface

            processes[0] = new EnglishFBP(stringInput);
            //processes[1] = new EnglishFBP(stringInput);
            //processes[2] = new EnglishFBP(stringInput);

            // Diego: Thread all processes here for FBP & add runtime start/stops

            // return results here
            for (int i = 0; i < 3; i++)
                langs[i] = ILangProcess.Lang;


            int count = 0;
            foreach (var lang in langs) {
                if (lang.probability < 0.5)
                    count++;
            }
            if (count > 0) { }
                // Slow Brain processes



            return langs;
        }
    }
}
