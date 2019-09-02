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
    public partial class incentives : Form
    {
        public incentives()
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

        public void btnokempid_Click(object sender, EventArgs e)
        {
            btnokempid.Focus();
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "select name,designation,department,doj from addemp where Id=@empid";
                string empid = txt_empid.Text.Trim();
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@empid", empid);
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
                String query = "INSERT INTO incentives VALUES(@Id,@name,@designation,@department,@doj,@hra,@da,@ta,@medical,@others,@totalamount)";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Id", txt_empid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@designation", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@department", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@doj", textBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@hra", txthra.Text.Trim());
                    cmd.Parameters.AddWithValue("@da", txtda.Text.Trim());
                    cmd.Parameters.AddWithValue("@ta", txtta.Text.Trim());
                    cmd.Parameters.AddWithValue("@medical", txtmedical.Text.Trim());
                    cmd.Parameters.AddWithValue("@others", txtothers.Text.Trim());
                    cmd.Parameters.AddWithValue("@totalamount", txttotal.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("the incentives has been saved successfully!");
                    con.Close();
                    Home hm = new Home();
                    hm.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                string msg = "The Incentives Details for this Employee has been already Calculated.";
                MessageBox.Show(msg, "Already Done!");
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "SELECT salaryamount from basicsalary where name=@name and designation=@designation and department=@department and doj=@doj";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@designation", textBox2.Text);
                    cmd.Parameters.AddWithValue("@department", textBox3.Text);
                    cmd.Parameters.AddWithValue("@doj", textBox4.Text);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        String salaryamount = reader.GetValue(0).ToString();
                        MessageBox.Show("Your basic Salary is:" + salaryamount);

                        //Incentives calculation................
                        int a = Convert.ToInt32(salaryamount);

                        // HRA calculation.......................
                        int b = int.Parse(textperhra.Text);
                        int c = (a * b / 100);
                        txthra.Text = c.ToString();

                        //DA calculation............
                        int da = int.Parse(textperda.Text);
                        int daam = (a * da) / 100;
                        txtda.Text = daam.ToString();

                        // TA calculation........
                        int ta = int.Parse(textperta.Text);
                        int taam = (a * ta / 100);
                        txtta.Text = taam.ToString();

                        //Medical calculation................
                        int me = int.Parse(textpermedical.Text);
                        int meam = (a * me / 100);
                        txtmedical.Text = meam.ToString();

                        // others incentives calculation.......
                        int ot = int.Parse(textperothers.Text);
                        int otam = (a * ot / 100);
                        txtothers.Text = otam.ToString();

                        // Addition of all Incentives amount...........
                        int sumall = c + daam + taam + meam + otam;
                        txttotal.Text = sumall.ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textperhra_Leave(object sender, EventArgs e)
        {

        }

    }

}