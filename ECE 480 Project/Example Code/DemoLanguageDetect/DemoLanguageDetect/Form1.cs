using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace DemoLanguageDetect
{    
    public partial class mainWindow : Form
    {
        public static string stringInput;
        public  static Task task1;

        public mainWindow()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            Callwait();
            //Form2 ResultForm = new Form2(stringInput);
            label1.Text = "puto";
            
         
            //ResultForm.Show();
           //MessageBox.Show("Input String is \"" + stringInput + "\"\rProbability = {1}\rLanguage is {2} ");
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public  void waiting()
        {
            Thread.Sleep(5000);
            stringInput = inputText.Text;
            Form2 ResultForm = new Form2("vales verga");
            ResultForm.label1.Text = "MAS PUTS" ;
            ResultForm.Show();
            
        }
        public  Task waitingAsync()
        {
            task1 = Task.Factory.StartNew(() => waiting());
            return task1;
        }
        private  async void Callwait()
        {
            await waitingAsync();
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
      }
  
   
  }
