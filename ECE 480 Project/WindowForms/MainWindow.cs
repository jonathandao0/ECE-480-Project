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
        public static Task task;
        public string stringInput, ID;
        double probability; //not used anymore

        public mainWindow()
        {
            InitializeComponent();
            inputText.ScrollBars = ScrollBars.Vertical; //add scroll bar
        }

        private void detect_lang_Click(object sender, EventArgs e)
        {
            bool isAllNumber =  true; //to check if input contains only numbers/digits
            foreach (char c in inputText.Text)
                if (c < '0' || c > '9')
                    isAllNumber = false;

            if (string.IsNullOrEmpty(inputText.Text)) //to check if input is empty
                MessageBox.Show("Your input is empty!");
            else if (isAllNumber)
                MessageBox.Show("Your input does not contain any character!");
            else
            {
              
                stringInput = inputText.Text;

                var languages = new Language();

                // Run the main program
                languages = MainProgramCode.MainProgram(stringInput);//,out ID, out probability);

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
    /*    public  void RealTimeDisplay()
        {
            stringInput = inputText.Text;

            var languages = new Language();

            // Run the main program
            languages = MainProgramCode.MainProgram(stringInput);//,out ID, out probability);

            // change input from string to Language[]
            var ResultForm = new ResultWindow(languages);
            ResultForm.Show();
           // this.Hide(); //hide current window
        }
        public Task RealTimeDisplayTask () 
        {
            task = Task.Factory.StartNew(() => RealTimeDisplay());
            return task;
        }
        public async void CallRealTimeDisplay()
        {
            await RealTimeDisplayTask() ;
        }*/
            
    }
}
