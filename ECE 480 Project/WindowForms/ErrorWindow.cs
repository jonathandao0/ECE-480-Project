using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE_480_Project.WindowForms
{
    public partial class ErrorWindow : Form
    {
        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void ErrorWindow_Load(object sender, EventArgs e)
        {
            // Use this window to output error messages.
            // The window title will be Error
            // It will have an "Okay" button to close it
            // It will take a string input as the error message
        }
    }
}
