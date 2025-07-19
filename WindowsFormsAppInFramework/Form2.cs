using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppInFramework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     

        private void Controls_Click(object sender, EventArgs e)//sender will identify which control is pressed 
        {
            if(sender.GetType().Name == "Button")
            {
                //Button button = (Button)sender;
               // MessageBox.Show("You clicked on " + button.Text);
               MessageBox.Show("You clicked on a button control.");
            }
            else if (sender.GetType().Name == "TextBox")
            {
                //TextBox textBox = (TextBox)sender;
               // MessageBox.Show("You typed: " + textBox.Text);
               MessageBox.Show("You clicked on a text box control.");
            }
            else
            {
                MessageBox.Show("Form control clicked.");
            }
        }
    }
}
