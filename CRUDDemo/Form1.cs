using Microsoft.Data.SqlClient;
using System.Data;

namespace CRUDDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=localhost;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=true");
            cmd = new SqlCommand();//Define command object using SqlCommand class AND create its instance using new keyword and SqlCommand() constructor which is default constructor
            cmd.Connection = con;//Set the Connection property of command object to the connection object
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            cmd.CommandText = "Select Eno,Ename,Job,Salary,Status from Employee Where Status=1 Order By Eno";
            dr = cmd.ExecuteReader();//data is loaded from database table into data reader object
            Show();
        }
        private void Show()
        {
            if (dr.Read())
            {
                textBox1.Text = dr["Eno"].ToString();//Why ToString() method is used here because dr["Eno"] returns object type data so to convert it into string we are using ToString() method
                textBox2.Text = dr["Ename"].ToString();
                textBox3.Text = dr["Job"].ToString();
                textBox4.Text = dr["Salary"].ToString();
                checkBox1.Checked = (bool)dr["Status"];//Here we are type casting object type data into bool type data.The purpose of this is to set the Checked property of CheckBox control which is of bool type
            }
            else
            {
                MessageBox.Show("Either table is Empty or You are at last record ", "Warning", MessageBoxButtons.OK);
                dr.Close();//we are closing the data reader object because it is holding the connection to database table.so to execute any other query we need to close it first.
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";//this way we can assign multiple textboxes to empty string.without repeating the assignment operator
            checkBox1.Checked = false;
            dr.Close();//we are closing the data reader object because it is holding the connection to database table.so to execute any other query we need to close it first.
            cmd.CommandText="Select IsNull(Max(Eno),100) + 1 From Employee";//we are using IsNull function to handle the case when table is empty.as Max function returns null when table is empty.and we are overrding CommandText property of command object to new sql query.
            textBox1.Text = cmd.ExecuteScalar().ToString();//ExecuteScalar method is used to retrieve a single value from database table.
            btnInsert.Enabled = checkBox1.Enabled=true;//it will enable the Insert button
            textBox2.Focus();//it will set the focus to textBox2 control

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"Insert Into Employee (Eno,Ename,Job,Salary,Status) Values({textBox1.Text},'{textBox2.Text}','{textBox3.Text}',{textBox4.Text},{Convert.ToInt32(checkBox1.Checked)})";
            if(cmd.ExecuteNonQuery()>0)//ExecuteNonQuery method is used to execute Insert,Update,Delete queries.it returns the no of rows affected.
            {
                LoadData();//the purpose of this is to reset the data reader object to point to the start of the table because after inserting a new record we want to show the records from start.
                btnInsert.Enabled = checkBox1.Enabled = false;//it will disable both controls

            }
            else
            {
                MessageBox.Show("Failed Inserting record into the table .", "Failure", MessageBoxButtons.OK);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dr.Close();
            cmd.CommandText=$"Update Employee Set Ename='{textBox2.Text}',Job='{textBox3.Text}',Salary={textBox4.Text},Status={Convert.ToInt32(checkBox1.Checked)} Where Eno={textBox1.Text}";
            if(cmd.ExecuteNonQuery()>0)
            {
               
                MessageBox.Show("Record Updated Successfully.", "Success", MessageBoxButtons.OK);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed Updating record into the table .", "Failure", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;//it will exit from this event handler
            }
            dr.Close();
            cmd.CommandText = $"Update Employee Set Status=0 Where Eno={textBox1.Text} ";
            if (cmd.ExecuteNonQuery() > 0)
            {

                MessageBox.Show("Record Deleted Successfully.", "Success", MessageBoxButtons.OK);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed Deleting record into the table .", "Failure", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();//here "this" represents current form object.it will close the current form
        }
    }
}
