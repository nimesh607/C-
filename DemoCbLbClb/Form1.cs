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

        /*Acessing all items from list controls:
     <ListControl>.Items => returns Object[]
     How to access selected items from list controls:
     Combobox:
                   Property         returns
                   SelectedItem      Object
                   SelectedIndex     int
                   Text             string
     ListBox:
                   Property         returns
                   SelectedItem      Object
                   SelectedIndex     int
                   SelectedItems     Object[]
                   SelectedIndices   int[]
     CheckedListBox:
                   Property         returns
                   SelectedItem      Object
                   SelectedIndex     int
                   SelectedItems     Object[]
                  SelectedIndices   int[]
                  CheckedItems      Object[]
                  CheckedIndices    int[]
     Note: In CheckedListBox user can select items using checkboxes but SelectedItems and SelectedIndices properties return only those items which are selected by mouse click or keyboard navigation.
     */


        private void button1_Click(object sender, EventArgs e)
        {
        
            MessageBox.Show(" Selected Country: "+comboBox1.Text);
            MessageBox.Show(" Selected Country:"+comboBox1.SelectedItem);//when you are concatenating you don't require to string()
               MessageBox.Show(" Selected Index: " + comboBox1.Items[comboBox1.SelectedIndex]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(object item in listBox1.SelectedItems)//its an Object[] so to acess each item we use foreach loop
            {
                MessageBox.Show(" Selected State: " + item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* //Old Way
              String Cities = "";
             foreach (string item in checkedListBox1.CheckedItems)
             {
                 Cities += item + ", ";
             }

             Cities = Cities.Substring(0, Cities.Length - 2);
             int position = Cities.LastIndexOf(',');
             if(position != -1)
             {
                 Cities = Cities.Remove(position, 1);
                 Cities = Cities.Insert(position, " and ");
             }

             MessageBox.Show("Selected Cities:" + Cities);
            */

            List<string> selectedCities = new List<string>();

            // Collect all checked items as strings
            foreach (object item in checkedListBox1.CheckedItems)
            {
                selectedCities.Add(item.ToString());
            }

            string formattedCities = string.Join(", ", selectedCities);

            // Replace last comma with " and "
            int lastCommaPos = formattedCities.LastIndexOf(',');
            if (lastCommaPos != -1)
            {
                formattedCities = formattedCities.Remove(lastCommaPos, 1)
                                                 .Insert(lastCommaPos, " and");
            }

            // Show result
            MessageBox.Show(formattedCities);


        
        
        }


    }
}
