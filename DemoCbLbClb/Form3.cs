using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCbLbClb
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Text = "";
            listBox1.Items.Clear();
            checkedListBox1.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listBox1.Items.AddRange(new String[] {"Gujarat","Rajasthan","Tamil Nadu"  });
                    break;
                case 1:
                    listBox1.Items.AddRange(new String[] { "California", "Texas", "Florida" });
                    break;
                case 2:listBox1.Items.AddRange(new String[] { "Quebec", "Ontario", "Alberta" });
                    break;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            switch (listBox1.SelectedItem.ToString())
            {
                case "Gujarat":
                    checkedListBox1.Items.AddRange(new String[] { "Ahmedabad","Surat","Vadodara"});
                    break;
                case "Rajasthan":
                    checkedListBox1.Items.AddRange(new string[] { "Jaipur", "Udaipur", "Jodhpur" });
                    break;
                case "Tamil Nadu":
                    checkedListBox1.Items.AddRange(new string[] { "Chennai", "Madurai", "Coimbatore" });
                    break;
                case "California":
                    checkedListBox1.Items.AddRange(new string[] { "Los Angeles", "San Francisco", "San Diego" });
                    break;
                case "Texas":
                    checkedListBox1.Items.AddRange(new string[] { "Houston", "Dallas", "Austin" });
                    break ;
                case "Florida":
                    checkedListBox1.Items.AddRange(new string[] { "Miami", "Orlando", "Tampa" });
                    break;
                case "Quebec":
                    checkedListBox1.Items.AddRange(new string[] { "Montreal", "Quebec", "Laval" });
                    break;
                case "Ontario":
                    checkedListBox1.Items.AddRange(new string[] { "Toronto", "London", "Windsor" });
                    break;
                case "Alberta":
                    checkedListBox1.Items.AddRange(new string[] { "Calgary", "Edmonton", "Red Deer" });
                    break;


            }
        }
    }
}
