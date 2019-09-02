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
using System.Data.SqlClient;

namespace Payroll
{
    public partial class deduction : Form
    {
        public deduction()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@designation", textBox2.Text);
                    cmd.Parameters.AddWithValue("@department", textBox3.Text);
                    cmd.Parameters.AddWithValue("@doj", textBox4.Text);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "INSERT INTO deduction VALUES(@Id,@name,@designation,@department,@doj,@protax,@advance,@provisional,@loan,@DeductedByLeaves,@totaldeduction)";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Id",textempid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@designation",textBox2.Text);
                    cmd.Parameters.AddWithValue("@department",textBox3.Text);
                    cmd.Parameters.AddWithValue("@doj",textBox4.Text);
                    cmd.Parameters.AddWithValue("@protax",textpro.Text.Trim());
                    cmd.Parameters.AddWithValue("@advance",textad.Text.Trim());
                    cmd.Parameters.AddWithValue("@provisional",textprov.Text.Trim());
                    cmd.Parameters.AddWithValue("@loan",textloan.Text.Trim());
                    cmd.Parameters.AddWithValue("@DeductedByLeaves", txt_leave.Text.Trim());
                    cmd.Parameters.AddWithValue("@totaldeduction",txttotal.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The Deduction Details has been saved Succesfully!");
                    con.Close();
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                string msg = "The Deduction Details for this Employee has been already Calculated.";
                MessageBox.Show(msg, "Already Done!");
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            try
            {
                //this is  the way to calculate total deduction................
                float a = float.Parse(textpro.Text);
                float b = float.Parse(textad.Text);
                float c = float.Parse(textprov.Text);
                float d = float.Parse(textloan.Text);
                float ee = float.Parse(txt_leave.Text);
                float totaldeduction = a + b + c + d + ee;
                txttotal.Text = totaldeduction.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void deduction_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

