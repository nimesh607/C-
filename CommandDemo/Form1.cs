using Microsoft.Data.SqlClient;
using System.Data;

namespace CommandDemo

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
            
            con = new SqlConnection("Data Source=localhost;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=True");// Create SqlConnection object
            cmd = new SqlCommand("Select Deptno,Dname,Location From Dept Order by Deptno", con);// Create SqlCommand object 
            con.Open();// Open the connection
            dr = cmd.ExecuteReader();// ExecuteReader returns SqlDataReader object. use when we want to execute a Select Statement that returns records as a rows and columns.the method returns an object of SqlDataReader class which holds the data that is retrieved from the datasource in the form of Rows & Columns. 

            //Acessing the metadata of the records using GetName() method of SqlDataReader class
            //Acessing and Assigning the column names to the labels
            label2.Text = dr.GetName(0) + ":";//Returns the name of the column at the specified index
            label3.Text = dr.GetName(1) + ":";
            label4.Text = dr.GetName(2) + ":";

            ShowData();
        }
        private void ShowData()
        {
            //Acessing the records using Read() method of SqlDataReader class
            // Read() returns true if there is a record to read else returns false 
            if (dr.Read())
            {
                textBox1.Text = dr.GetValue(0).ToString();// GetValue(int ColumnIndex)  returns object
                textBox2.Text = dr[1].ToString();          // Indexer[int ColumnIndex] returns object
                textBox3.Text = dr["Location"].ToString();// Indexer[string ColumnName] returns object
            }
            else
            {
                MessageBox.Show("You are at the last record of table.", "Information", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();
        }
    }
}
