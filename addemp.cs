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
    public partial class addemp : Form
    {
        public addemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                String query = "INSERT INTO addemp VALUES(@Id,@name,@fname,@gender,@dob,@address,@city,@state,@pincode,@contact,@email,@designation,@department,@doj,@remark)";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", txt_empid.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", textname.Text.Trim());
                    cmd.Parameters.AddWithValue("@fname", textfname.Text.Trim());
                    //radio button code
                    String gender = String.Empty;
                    if (rbtnmale.Checked)
                    {
                        gender = "Male";
                    }
                    else if (rbtnfemale.Checked)
                    {
                        gender = "Female";
                    }
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", textdob.Text);
                    cmd.Parameters.AddWithValue("@address", textaddress.Text);
                    cmd.Parameters.AddWithValue("@city", textcity.Text);
                    cmd.Parameters.AddWithValue("@state", textstate.Text);
                    cmd.Parameters.AddWithValue("@pincode", textpin.Text);
                    cmd.Parameters.AddWithValue("@contact", textcontact.Text);
                    cmd.Parameters.AddWithValue("@email", textemail.Text.Trim());
                    cmd.Parameters.AddWithValue("@designation", textdesignation.Text.Trim());
                    cmd.Parameters.AddWithValue("@department", textdepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@doj", textdoj.Text);
                    cmd.Parameters.AddWithValue("@remark", textremark.Text.Trim());
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Registration successfully compeleted!");
                    Home hm = new Home();
                    this.Hide();
                    hm.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Please Use another Employee Id.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
