using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace DataGridViewDemo
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString;
            da = new SqlDataAdapter("Select * from Employee", ConStr);
            ds = new DataSet();
            da.Fill(ds, "Employee");
            dataGridView1.DataSource = ds.Tables["Employee"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            da.Update(ds.Tables["Employee"]);
            MessageBox.Show("Data Saved Successfully", "Sucess", MessageBoxButtons.OK);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
