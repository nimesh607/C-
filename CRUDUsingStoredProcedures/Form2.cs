using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CRUDUsingStoredProcedures
{
    public partial class Form2 : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString;
            da = new SqlDataAdapter("Employee_Select", ConStr); 
            ds= new DataSet();
            da.Fill(ds, "Employee");
            dataGridView1.DataSource = ds.Tables["Employee"];
        }
    }
}
