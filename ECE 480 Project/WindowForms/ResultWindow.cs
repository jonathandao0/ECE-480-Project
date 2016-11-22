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
        string stringInput;
        public ResultWindow(string parseInput)
        {
            InitializeComponent();
            stringInput = parseInput;
            /* Things to add/change:
            1. languages and their probailities should be listed in descending order
            2. stringInput should not look like an input
            */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inputText.Text = stringInput; 
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }
                
    }
}
