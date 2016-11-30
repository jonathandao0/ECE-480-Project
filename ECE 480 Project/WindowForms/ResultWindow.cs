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
        double probability, fbRuntime, sbRuntime;


        public ResultWindow(Language lang)
        {
            InitializeComponent();
            //foreach(var lang in languages)
            stringInput = lang.inputString;
            probability = lang.probability;
            fbRuntime = lang.fastBrainRuntime;
            sbRuntime = lang.slowBrainRuntime;

            // probably need to convert from shorthand to long (e.g. en-> english, sp -> spanish, ru -> russian)
            ID = lang.languageType;

            showInput.ScrollBars = ScrollBars.Vertical; //add scroll bar

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
            showInput.Text = stringInput;
            fastbrainRuntime.Text = fbRuntime.ToString();
            slowbrainRuntime.Text = sbRuntime.ToString();
            probOutput.Text = probability.ToString() + " %";
            if (probability == 0)
                result.Text = "Undefined";
            else 
                switch (ID)
                {
                    case "en":
                        result.Text = "English";
                        break;
                    case "es":
                        result.Text = "Spanish";
                        break;
                    case "ru":
                        result.Text = "Russian";
                        break;
                    default:
                        result.Text = "Undefined";
                        break;
                }
        }         
    }
}
