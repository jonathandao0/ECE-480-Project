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
    public partial class AdminModeWindow : Form
    {
        public string stringInputTest, IDtest;
        double probabilityTest;

        public AdminModeWindow()
        {
            InitializeComponent();
        }

        private void AdminModeWindow_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void backToMain_click(object sender, EventArgs e)
        {
            var mainWindow = new mainWindow();
            mainWindow.Show();
            this.Hide(); // hide current window
        }

        //Handling Radio Button:checked and unchecked:
        bool isChecked;
        private void writeToDict_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = writeToDict.Checked;
        }
        private void writeToDict_click(object sender, EventArgs e)
        {
            if (writeToDict.Checked && !isChecked) // if radio button is already checked
            {
                writeToDict.Checked = false;
            }
            else //if it's not checked
            {
                writeToDict.Checked = true;
                isChecked = false; 
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show("Your input is invalid");
            }
            else
            {
                stringInputTest = inputText.Text;

                var languages = new Language[3];

                // Run the main program
                languages = MainProgramCode.MainProgram(stringInputTest, out IDtest, out probabilityTest);

                // change input from string to Language[]
                var ResultForm = new ResultWindow(stringInputTest, IDtest, probabilityTest);
                ResultForm.Show();
            }
        }
    }
}
