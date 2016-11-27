using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE_480_Project
{
    public partial class ResultWindow : Form
    {
        string stringInput, ID;
        double probability;
        
        public ResultWindow(string parseInput, string lang, double prob)
        {
            InitializeComponent();
            stringInput = parseInput;
            probability = prob;
            ID = lang;
            /* Things to add/change:
            1. languages and their probailities should be listed in descending order
            2. stringInput should not look like an input
            */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inputText.Text = stringInput;
            probOutput.Text = probability.ToString() + "%";
            result.Text = ID;
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }
                
    }
}
