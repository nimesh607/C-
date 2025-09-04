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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //To add items in listbox :<ListControl>.Items.Add("item");
            listBox1.Items.Add("Rajasthan");
            listBox1.Items.Add("Gujarat");
            listBox1.Items.Add("MadhyaPradesh");
            listBox1.Items.Add("AndhraPradesh");
            listBox1.Items.Add("Assam");

            string[] cities = { "Jaipur", "Udaipur", "Kota", "Bikaner", "Jodhpur" ,"Hyderabad"};
            //To add multiple items in listbox :<ListControl>.Items.AddRange(array);
            checkedListBox1.Items.AddRange(cities);

            //To add items from datasource:
            //Step1:<ListControl>.DataSource = <database Table>;
            //Step2:<ListControl>.DisplayMember = "<column name to be displayed>";

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Add item dynamically to combobox when user press Enter key 
            if (Convert.ToInt32(e.KeyChar)==13) //13 is ASCII value of Enter key
            {
                if (comboBox1.FindStringExact(comboBox1.Text) == -1)
                    {
                    comboBox1.Items.Add(comboBox1.Text);
                   // comboBox1.Text = "";
                }
            }
        }
    }
}
