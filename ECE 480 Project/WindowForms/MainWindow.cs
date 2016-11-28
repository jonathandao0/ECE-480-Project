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
        public string stringInput, ID;
        double probability;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void detect_lang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputText.Text))
            {
                MessageBox.Show("Your input is invalid");
            }
            else
            {
                stringInput = inputText.Text;

                var languages = new Language[3];

                // Run the main program
                languages = MainProgramCode.MainProgram(stringInput,out ID, out probability);

                // change input from string to Language[]
                var ResultForm = new ResultWindow(languages);
                ResultForm.Show();
                this.Hide(); //hide current window
            }
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                detect_lang_Click(sender, e);
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

        }

        private void admin_mode_Click(object sender, EventArgs e)
        {
            // Can we make this a new tab? Or replace the current window
            var AdminForm = new AdminModeWindow();
            AdminForm.Show();
            this.Hide(); //hide current window
        }        
    }
}
