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
    public partial class Bonus : Form
    {
        public Bonus()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "INSERT INTO bonus VALUES(@Id,@name,@designation,@department,@doj,@bonustype,@bonusamount,@remark)";
                String bonustype = String.Empty;
                if (rbtnmonthly.Checked)
                {
                    bonustype = "Monthly";
                }
                else if (rbtndaily.Checked)
                {
                    bonustype = "Daily";
                }
                else if (rbtnweekly.Checked)
                {
                    bonustype = "Weekly";

                }
                else if (rbtnhourly.Checked)
                {
                    bonustype = "Hourly";
                }
                else if (rbtnyearly.Checked)
                {
                    bonustype = "Yearly";
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
                    cmd.Parameters.AddWithValue("@bonustype", bonustype);
                    cmd.Parameters.AddWithValue("@bonusamount", textbonusamount.Text.Trim());
                    cmd.Parameters.AddWithValue("@remark", textremark.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Bonus Data has been succcessfully saved!");
                    con.Close();
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
            }
            catch(Exception )
            {
                string msg = "The Bonus Details for this Employee has been already Calculated.";
                MessageBox.Show(msg,"Already Done!");
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
        }

        private void btnokempid_Click(object sender, EventArgs e)
        {
            try
            {

                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "select name,designation,department,doj from addemp where Id=@empid";
                String empid = textempid.Text.Trim();
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@empid", empid);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.Read())
                    {
                        textBox1.Text = rdr.GetValue(0).ToString();
                        textBox2.Text = rdr.GetValue(1).ToString();
                        textBox3.Text = rdr.GetValue(2).ToString();
                        textBox4.Text = rdr.GetValue(3).ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //Controls.Clear();
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
