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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:comboBox2.Items.AddRange(new string[] { "January", "February", "March" });
                    break;
                case 1:
                    comboBox2.Items.AddRange(new string[] { "April", "May", "June" });
                    break;
                case 2:
                    comboBox2.Items.AddRange(new string[] { "July", "August", "September" });
                    break;
                case 3:
                    comboBox2.Items.AddRange(new string[] { "October", "November", "December" });
                    break;
            }
        }
    }
}
