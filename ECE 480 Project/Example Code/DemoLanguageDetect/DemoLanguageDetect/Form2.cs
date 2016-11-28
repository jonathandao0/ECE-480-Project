using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLanguageDetect
{
    public partial class Form2 : Form
    {
        string stringInput;
        public Form2(string parseInput)
        {
            InitializeComponent();
            stringInput = parseInput;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inputText.Text = stringInput; 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
                
    }
}
