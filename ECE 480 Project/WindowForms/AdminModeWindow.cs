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
        string[] ngramEng, ngramSpan, ngramRus, wordEng, wordSpan, wordRus;

        public AdminModeWindow()
        {
            InitializeComponent();
        }

        private void updatingGrid(string selectLang)
        {
            ngramDataGrid.Rows.Clear(); //clear each time it updates
            wordDataGrid.Rows.Clear();
            ngramDataGrid.Columns.Clear();
            wordDataGrid.Columns.Clear();

            ngramDataGrid.Columns.Add("ngram", "N-Gram"); //parameter: (name, header text)
            wordDataGrid.Columns.Add("words", "Word");
                      
            switch(selectLang)
            {
                case "English":
                    for (int i = 0; i < ngramEng.Length; i++)
                        ngramDataGrid.Rows.Add(new object[] { ngramEng[i] }); //what is in the row 
                    for (int i = 0; i < wordEng.Length; i++)
                        wordDataGrid.Rows.Add(new object[] { wordEng[i] }); 
                    break;
                /*case "Spanish":
                    for (int i = 0; i < ngramSpan.Length; i++)
                        ngramDataGrid.Rows.Add(new object[] { ngramSpan[i] }); //what is in the row 
                    for (int i = 0; i < wordSpan.Length; i++)
                        wordDataGrid.Rows.Add(new object[] { wordSpan[i] });
                    break;
                case "Russian":
                    for (int i = 0; i < ngramRus.Length; i++)
                        ngramDataGrid.Rows.Add(new object[] { ngramRus[i] }); //what is in the row 
                    for (int i = 0; i < wordRus.Length; i++)
                        wordDataGrid.Rows.Add(new object[] { wordRus[i] });
                    break;*/
                default:
                    break;
            }
            
        }
        private void AdminModeWindow_Load(object sender, EventArgs e)
        {
            ngramEng = AdminModeInitialize.intitalizeEnglishNGram();    
            wordEng = AdminModeInitialize.intitalizeEnglishDictionary();

            // belows:intitalizeSpanishDictionary() error so i commented out
            /*ngramSpan = AdminModeInitialize.intitalizeSpanishNGram();
            wordSpan = AdminModeInitialize.intitalizeSpanishDictionary();
            ngramRus = AdminModeInitialize.intitalizeRussianNGram();
            wordRus = AdminModeInitialize.intitalizeRussianDictionary();*/

            updatingGrid("English"); //show english as default
        }

        private void backToMain_click(object sender, EventArgs e)
        {
            var mainWindow = new mainWindow();
            mainWindow.Show();
            this.Hide(); // hide current window
        }
          
        //Handle selection Box:        
        private void selectLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLang = selectLang.Text;            
            updatingGrid(selectedLang); //run event to update data boxes
        }

       
        private void testButton_Click(object sender, EventArgs e)
        {
            bool isAllNumber = true; //to check if input contains only numbers/digits
            foreach (char c in inputText.Text)
                if (c < '0' || c > '9')
                    isAllNumber = false;

            if (string.IsNullOrEmpty(inputText.Text)) //to check if input is empty
                MessageBox.Show("Your input is empty!");
            else if (isAllNumber)
                MessageBox.Show("Your input does not contain any character!");
            else
            {
                stringInputTest = inputText.Text;

                var languages = new Language();

                // Run the main program
                languages = MainProgramCode.MainProgram(stringInputTest);

                // change input from string to Language[]
                var ResultForm = new ResultWindow(languages);
                ResultForm.Show();
                //this.Hide(); in admin mode i kinda dont want to hide this
            }
        }
    }
}
