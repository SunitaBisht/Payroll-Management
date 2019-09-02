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
    public partial class BasicSalary : Form
    {
        public BasicSalary()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void BasicSalary_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String Query = "select name, designation,department,doj from addemp where Id=@id";
                //String empId = textempid.Text.Trim();
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(Query);
                     cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id",textempid.Text.Trim());
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                  
                    if(rdr.Read())
                    {
                        textBox1.Text = rdr.GetValue(0).ToString();
                        textBox2.Text = rdr.GetValue(1).ToString();
                        textBox3.Text = rdr.GetValue(2).ToString();
                        textBox4.Text = rdr.GetValue(3).ToString();
                    }
                    //MessageBox.Show("OK, Done!");
                    con.Close();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "INSERT INTO basicsalary VALUES(@Id,@name,@designation,@department,@doj,@salarytype,@salaryamount,@remark)";
                
                String salarytype = String.Empty;
                if(rbtnmonthly.Checked)
                {
                    salarytype = "Monthly";
                }
                else if(rbtndaily.Checked)
                {
                    salarytype = "Daily";
                }
                else if(rbtnweekly.Checked)
                {
                    salarytype = "Weekly";

                }
                else if(rbtnhourly.Checked)
                {
                    salarytype = "Hourly";
                }
                else if(rbtnyearly.Checked)
                {
                    salarytype = "Yearly";
                }
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Id", textempid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@designation", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@department", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@doj", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@salarytype", salarytype);
                    cmd.Parameters.AddWithValue("@salaryamount", textsalaryamount.Text.Trim());
                    cmd.Parameters.AddWithValue("@remark", textremark.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Data has been Successfully saved!");
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
                string msg = "The Basic Salary Details for this Employee has been already Calculated.";
                MessageBox.Show(msg,"Already Done!");
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
        }
    }
}
