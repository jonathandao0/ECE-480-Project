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
          
        //Handle selection Box:
        string selectedLang;
        private void selectLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLang = selectLang.Text; 
            //run event to update data boxes
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
                var ResultForm = new ResultWindow(languages);
                ResultForm.Show();
            }
        }
    }
}
