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
          // need maincode to return prob in array, so we can output all probabilities, 
          // otherwise, i cannot pull all the probabilities to GUI
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            var mainWindow = new mainWindow();
            mainWindow.Show();
            this.Hide(); // hide current window
        }

        private void resultWindow_Load(object sender, EventArgs e)
        {
            input.Text = stringInput;
            probOutput.Text = probability.ToString() + "%";
            switch (ID)
            {
                case "en":
                    result.Text = "English";
                    break;
                case "es":
                    result.Text = "Spanish";
                    break;
                case "jp":
                    result.Text = "Japanese";
                    break;
                default:
                    break;

            }
        }
           
                
    }
}
