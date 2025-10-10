using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;

namespace CRUDDemo
{
    public partial class Form2 : Form
    {
        int RowIndex = 0;//Index of current row of DataTable

        DataSet ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            con = new SqlConnection("Data Source=localhost;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=true");

            /*
             * there are 4 constructor  of data adapter class 
             */
            cmd = new SqlCommand("Select Eno,Ename,Job,Salary From Employee Where Status=1 Order by Eno", con);
            da = new SqlDataAdapter(cmd);  //with command object

            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;//it will add primary key information to DataTable while filling the DataSet object

            ds = new DataSet();
            da.Fill(ds, "Employee");//Data Set is loaded with data 

            showData();

            /*
             * this is another way to fill the DataSet object
             cmd=new SqlCommand("Select Eno,Ename,Job,Salary From Employee Order by Eno",con);
            da=new SqlDataAdapter(); //default constructor
            da.selectcommand=cmd;  
            ds = new DataSet();  
             da.Fill(ds,"Employee");
             */

            /*
            * this is another way to fill the DataSet object
           da=new SqlDataAdapter("Select Eno,Ename,Job,Salary From Employee Order by Eno",con); //no need to create command object.da will create command object internally
           da.selectcommand=cmd;  
           ds = new DataSet();  
            da.Fill(ds,"Employee");
            */


            /*
            * this is another way to fill the DataSet object
           da=new SqlDataAdapter("Select Eno,Ename,Job,Salary From Employee Order by Eno","Data Source=localhost;Database=CSDB;Integrated Security=SSPI;TrustServerCertificate=true"); //no need to create command object.da will create command object internally and no need to create connection object also.da will create connection object internally
           ds = new DataSet();  
            da.Fill(ds,"Employee");
            */

        }

        private void showData()
        {
            if (ds.Tables["Employee"].Rows[RowIndex].RowState != DataRowState.Deleted)//to check whether the current row is deleted or not ,by checking the RowState property of DataRow class.
            {
                textBox1.Text = ds.Tables["Employee"].Rows[RowIndex]["Eno"].ToString();
                textBox2.Text = ds.Tables["Employee"].Rows[RowIndex]["Ename"].ToString();
                textBox3.Text = ds.Tables["Employee"].Rows[RowIndex]["Job"].ToString();
                textBox4.Text = ds.Tables["Employee"].Rows[RowIndex]["Salary"].ToString();
            }
            else
            {
                MessageBox.Show("Current Row is deleted and can't be accessed");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (RowIndex < ds.Tables[0].Rows.Count - 1)
            {
                RowIndex += 1;
                showData();
            }
            else
            {
                MessageBox.Show("You are at last record", "Information", MessageBoxButtons.OK);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (RowIndex > 0)
            {
                RowIndex -= 1;
                showData();
            }
            else
            {
                MessageBox.Show("You are at first record", "Information", MessageBoxButtons.OK);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            RowIndex = 0;
            showData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            RowIndex = ds.Tables[0].Rows.Count - 1;
            showData();
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";//this way we can assign multiple textboxes to empty string.without repeating the assignment operator

            int lastRowIndex = ds.Tables[0].Rows.Count - 1;
            int newEno = Convert.ToInt32(ds.Tables[0].Rows[lastRowIndex]["Eno"]) + 1;//Incrementing the last Eno by 1 to get new Eno.returns object type data so we are using Convert.ToInt32 method to convert it into int type data

            textBox1.Text = newEno.ToString();
            btnInsert.Enabled = true;

            textBox2.Focus();//it will set the focus to textBox2 control
        }

        private void btnSaveDb_Click(object sender, EventArgs e)
        {
            /* 
             * Manually defining the InsertCommand,UpdateCommand and DeleteCommand of DataAdapter object
             * da.InsertCommand.CommandText = "Insert Stmt";
             da.UpdateCommand.CommandText = "Update Stmt";
             da.DeleteCommand.CommandText = "Delete Stmt";
            */

            SqlCommandBuilder builder = new SqlCommandBuilder(da);//it will automatically generate the InsertCommand,UpdateCommand and DeleteCommand of DataAdapter object based on the SelectCommand of DataAdapter object.

            da.Update(ds, "Employee");//it will save the changes made in DataSet to database table

            MessageBox.Show("Changes Saved Successfully to Database", "Success", MessageBoxButtons.OK);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Employee"].NewRow();//Creating new row in DataTable.Row is a instance of DataRow class
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = textBox4.Text;
            ds.Tables["Employee"].Rows.Add(dr);//Adding new row to DataTable.Rows is a instance of DataRowCollection class
            btnInsert.Enabled = false;
            RowIndex = ds.Tables[0].Rows.Count - 1;//Setting the RowIndex to last row index because new row is added at the end of DataTable.
            MessageBox.Show("Record Inserted Successfully into DataSet", "Success", MessageBoxButtons.OK);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds.Tables["Employee"].Rows[RowIndex]["Ename"] = textBox2.Text;
            ds.Tables["Employee"].Rows[RowIndex]["Job"] = textBox3.Text;
            ds.Tables["Employee"].Rows[RowIndex]["Salary"] = textBox4.Text;
            MessageBox.Show("Record Updated Successfully in DataSet", "Success", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ds.Tables["Employee"].Rows[RowIndex].Delete();
            btnFirst.PerformClick();//it will perform click event of btnFirst button.this is done to show the first record after deleting the current record.

            MessageBox.Show("Record Deleted Successfully from DataSet", "Success", MessageBoxButtons.OK);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Import Microsoft.VisualBasic assembly to use InputBox function
            string value=Interaction.InputBox("Enter an employee number to search", "Search Employee");
            bool status = int.TryParse(value,out int Eno);
            if (status)
            {
                DataRow dr = ds.Tables[0].Rows.Find(Eno);//Find method of DataRowCollection class is used to search a row in DataTable based on primary key value.it returns DataRow type data.

                if(dr != null)
                {
                    RowIndex = ds.Tables[0].Rows.IndexOf(dr);//IndexOf method of DataRowCollection class is used to get the index of a row in DataTable based on DataRow object.it returns int type data.
                    textBox1.Text = dr["Eno"].ToString();
                    textBox2.Text = dr["Ename"].ToString();
                    textBox3.Text = dr["Job"].ToString();
                    textBox4.Text = dr["Salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee Number not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Employee No must be an integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
