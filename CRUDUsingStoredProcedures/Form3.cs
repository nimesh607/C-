using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUDUsingStoredProcedures
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string imgPath = "";
        byte[] imgData = null;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (btnNew.Text == "New")
            {
                btnClear.PerformClick();
                btnNew.Text = "Insert";
            }
            else
            {
                try
                {
                    cmd.CommandText = "Employee_Insert";
                    /*Add parameters required for the stored procedure.Command is calling the procedure.and command will pass the values to the db.there are 5 perameters in the procedure so we need to add 5 parameters here.4 are input and 1 is output.To add input parameter the method is AddWithValue() and to add output parameter Add() method is used.Every parameter(Ename,Job...) is associated with 5 attributes .
                     * 1)Name of Parameter.2)Value:-If it is input the value u want to send if it is output the value you are expecting now.3)DataType:the dataype of parameter in db.
                     4)Size.5)Direction:Input or Output*/

                    cmd.Parameters.AddWithValue("@Ename", tbEname.Text);//Parameter for Ename and value.if you are passing value no need to specify datatype,size,direction because it is optional.and if you are passing value dataype is optional.if you are not pasing value i.e. Null then  you need to specify datatype .if you are passing null value use DBNull.Value 
                    cmd.Parameters.AddWithValue("@Job", tbJob.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(tbSalary.Text));

                    if (imgPath.Trim().Length > 0)
                    {
                        imgData = File.ReadAllBytes(imgPath);//Read the image file and convert into byte array
                        cmd.Parameters.AddWithValue("@Photo", imgData);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value);//If user not selected any image then pass null to database.here we are not passing any value so we need to specify datatype.
                        cmd.Parameters["@Photo"].SqlDbType = SqlDbType.VarBinary;//Specify the datatype of parameter as Image because by default it is VarBinary
                    }

                    cmd.Parameters.Add("@Eno", SqlDbType.Int, 4).Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    tbEno.Text = cmd.Parameters["@Eno"].Value.ToString();//Get the output parameter value and display in textbox

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                    cmd.Parameters.Clear();//Clear all the parameters from command object because we are using the same command object for all operations
                    btnNew.Text = "New";
                }

            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string value = Interaction.InputBox("Enter Employee No to Search ");
            if (int.TryParse(value, out int eno))
            {
                try
                {
                    cmd.CommandText = "Employee_Select";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Eno", eno);
                    cmd.Parameters.AddWithValue("@Status", true);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        tbEno.Text = dr["Eno"].ToString();
                        tbEname.Text = dr["Ename"].ToString();
                        tbJob.Text = dr["Job"].ToString();
                        tbSalary.Text = dr["Salary"].ToString();
                        if (dr["Photo"] != DBNull.Value)//If db value is not null.
                        {
                            imgData = (byte[])dr["Photo"];//object type is converted to byte array
                            MemoryStream ms = new MemoryStream(imgData);
                            pictureBox1.Image = Image.FromStream(ms);//FromStream method of Image class is used to convert byte array to image
                        }
                        else
                        {
                            imgData = null;
                            imgPath = "";
                            pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        btnClear.Enabled = false;
                        MessageBox.Show("No employee exist's with the given number.", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Employee No. should be integer value.", "Conversion Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            cmd.CommandText = "Employee_Select";
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            imgPath = "";
            imgData = null;
            tbEno.Text = tbEname.Text = tbJob.Text = tbSalary.Text = "";
            tbEname.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
               
                cmd.CommandText = "Employee_Update";
                //Add Parameters to update .for update pass all values
                cmd.Parameters.AddWithValue("@Eno", tbEno.Text);
                cmd.Parameters.AddWithValue("@Ename", tbEname.Text);
                cmd.Parameters.AddWithValue("@Job", tbJob.Text);
                cmd.Parameters.AddWithValue("@Salary", tbSalary.Text);
                
                if(imgData == null && imgPath.Trim().Length == 0)
                {
                    cmd.Parameters.AddWithValue("@Photo", DBNull.Value);
                    cmd.Parameters["@Photo"].SqlDbType = SqlDbType.VarBinary;
                }
                else if(imgPath.Trim().Length>0)
                {
                    imgData = File.ReadAllBytes(imgPath);
                    cmd.Parameters.AddWithValue("@Photo", imgData);
                }
                else if(imgData != null && imgPath.Trim().Length == 0)
                {
                    cmd.Parameters.AddWithValue("@Photo", imgData);
                }
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record is Updated Successfully", "Sucess", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK);

            }
            finally
            {
                con.Close();
                btnNew.Text = "New";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Employee_Delete";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Eno", tbEno.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                btnClear.PerformClick();
                MessageBox.Show("Record deleted from Database-Table.", "Information Message", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnloadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Jpeg Images|*.jpg|Bitmap Images|*.bmp|All Files|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                imgPath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = imgPath;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string ConStr = ConfigurationManager.ConnectionStrings["SqlConStr"].ConnectionString;
            con = new SqlConnection(ConStr);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            
        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
