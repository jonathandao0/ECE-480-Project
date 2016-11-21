using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE_480_Project
{
    interface ILangProcess
    {
        public static Language Lang { get; }
        void FastBrainProcess();
    }
}
