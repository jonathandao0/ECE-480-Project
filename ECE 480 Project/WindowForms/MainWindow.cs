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
    public partial class mainWindow : Form
    {
        public string stringInput;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void detect_lang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputText.Text))
            {
                // pop en error message
            }
            else
            {
                stringInput = inputText.Text;

                var languages = new Language[3];

                // Run the main program
                languages = MainProgramCode.MainProgramCode(stringInput);

                // change input from string to Language[]
                var ResultForm = new ResultWindow(stringInput);
                ResultForm.Show();
                //MessageBox.Show("Input String is \"" + stringInput + "\"\rProbability = {1}\rLanguage is {2} ");
            }
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                detect_lang_Click(sender, e);
        }

        private void admin_mode_Click(object sender, EventArgs e)
        {
            // Can we make this a new tab? Or replace the current window
            var AdminForm = new AdminModeWindow();
            AdminForm.Show();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
