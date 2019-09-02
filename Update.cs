using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Payroll
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String Query = "Update addemp Set name=@name and fname=@fname and gender=@gender and dob=@dob and address=@address and city=@city and state=@state and pincode=@pincode and contact=@contact and email=@email and designation=@designation and department=@department and doj=@doj and remark=@remark  where id=@id";
                String empid = textempid.Text;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(Query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@name", textname.Text.Trim());
                    cmd.Parameters.AddWithValue("@fname", textfname.Text.Trim());
                    // radio button code goes here.....
                    String gender = String.Empty;
                    if (btnmale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (btnfemale.Checked)
                    {
                        gender = "female";
                    }
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", textdob.Text.Trim());
                    cmd.Parameters.AddWithValue("@address", textaddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@city", textstate.Text.Trim());
                    cmd.Parameters.AddWithValue("@state", textstate.Text.Trim());
                    cmd.Parameters.AddWithValue("@pincode", textpincode.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", textcontact.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", textemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@designation", textdesignation.Text.Trim());
                    cmd.Parameters.AddWithValue("@department", textdepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@doj", textdoj.Text.Trim());
                    cmd.Parameters.AddWithValue("@remark", textremark.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", empid);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Employee Data updated successfully");
                    //btnupdate.Visible = false;
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
            }

        private void textdesignation_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

