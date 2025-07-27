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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Controls_Click(object sender, EventArgs e)//sender parameter is used for identifying the control which is raising the event when a event procedure is bound with multiple event
        {
            // Cast the sender to a Button so we can access its properties.
            // You can also write it as: Button b = sender as Button;
            // Just make sure to check for null if using 'as'.
            if (sender is Button)
            {
                 Button b = (Button)sender;
                if(b.Name == "button1") // Example usage: You can now access properties like b.Text, b.Name, etc. //or you can do like this :sender as Button.we are converting
                {
                    MessageBox.Show("Button 1 is clicked by the user");
                }
                else
                {
                    MessageBox.Show("Button2 is clicked by the user");
                }
                MessageBox.Show(b.Name);
            }
            else if(sender is TextBox)
                {
                TextBox tb = (TextBox)sender;
                if (tb.Name == "textBox1")//Note:texBox1 is instance name so it is in CamelCase .it is given by system .
                {
                    MessageBox.Show("TextBox1 is clicked by the user");
                }
                else
                {
                    MessageBox.Show("TextBox2 is clicked by the user");
                }
                MessageBox.Show(tb.Name);
            }
            else
            {
                MessageBox.Show("Form3 is clicked");
            }


 
        }
    }
}
