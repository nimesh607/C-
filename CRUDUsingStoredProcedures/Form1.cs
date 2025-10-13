using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CRUDUsingStoredProcedures
{
    /* 
     * This is Connected Architecture Example for Fetching Data from SQL Server Database using Stored Procedure 
     */
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
            string ConStr = ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString;
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand("Employee_Select", con);//Step 1: Create Command Object by passing Stored Procedure name and Connection object
            cmd.CommandType = CommandType.StoredProcedure;//Step 2: Mention the command type as Stored Procedure because by default it is Text(Sql Statement)
            con.Open();
            dr = cmd.ExecuteReader();//Step 3: Execute the command by calling ExecuteReader method of Command object which returns SqlDataReader object 
            ShowData();
        }

        private void ShowData()
        {


            if (dr.Read())
            {

                tbEno.Text = dr["Eno"].ToString();
                tbEname.Text = dr["Ename"].ToString();
                tbJob.Text = dr["Job"].ToString();
                tbSalary.Text = dr["Salary"].ToString();
                cbStatus.Checked = Convert.ToBoolean(dr["Status"]);

            }
            else
            {
                MessageBox.Show("You are at last record of table.");
            }
          
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
