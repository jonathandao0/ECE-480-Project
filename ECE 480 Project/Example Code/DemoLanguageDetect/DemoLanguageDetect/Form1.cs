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
    public partial class mainWindow : Form
    {
        public string stringInput;

        public mainWindow()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            stringInput = inputText.Text;
            Form2 ResultForm = new Form2(stringInput);
            ResultForm.Show();
            //MessageBox.Show("Input String is \"" + stringInput + "\"\rProbability = {1}\rLanguage is {2} ");
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

       
    }
}
