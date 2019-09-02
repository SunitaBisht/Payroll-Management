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
    public partial class NetSalary : Form
    {
        public NetSalary()
        {
            InitializeComponent();
        }

        private void btnokempid_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string query = "select b.salaryamount, bo.bonusamount,du.total_deduction,inc.totalamount from addemp as a join basicsalary as b on a.Id = b.Id join bonus as bo on a.Id = bo.Id join deduction as du on a.Id = du.Id join incentives as inc on a.Id = inc.Id where a.Id = @Id";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", txt_empid.Text.Trim());
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        txt_basicsalary.Text = rdr.GetValue(0).ToString();
                        txt_grossbonus.Text = rdr.GetValue(1).ToString();
                        txt_deduction.Text = rdr.GetValue(2).ToString();
                        txt_incentives.Text = rdr.GetValue(3).ToString();
                    }
                    con.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculation of Net salary...............................
            float basic_salary = float.Parse(txt_basicsalary.Text);
            float gross_bonus = float.Parse(txt_grossbonus.Text);
            float gross_incentives = float.Parse(txt_incentives.Text);
            float gross_deduction = float.Parse(txt_deduction.Text);

            float net_salary = (basic_salary + gross_bonus + gross_incentives) - gross_deduction;
            //Assigning value to the text box that show the net salary ..............
            txt_net_salary.Text = net_salary.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                string query = "INSERT INTO Final_Table VALUES(@Id,@net_salary,@net_salaryType)";
                String net_salaryType = String.Empty;
                if (rbtnmonthly.Checked)
                {
                    net_salaryType = "Monthly";
                }
                else if (rbtndaily.Checked)
                {
                    net_salaryType = "Daily";
                }
                else if (rbtnweekly.Checked)
                {
                    net_salaryType = "Weekly";

                }
                else if (rbtnhourly.Checked)
                {
                    net_salaryType = "Hourly";
                }
                else if (rbtnyearly.Checked)
                {
                    net_salaryType = "Yearly";
                }
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", txt_empid.Text.Trim());
                    cmd.Parameters.AddWithValue("@net_salary", txt_net_salary.Text.Trim());
                    cmd.Parameters.AddWithValue("@net_salaryType", net_salaryType);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("The Net Salary For the Employee Has been Saved into the Database");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Already calculated for this employee");
            }
        }

        private void NetSalary_Load(object sender, EventArgs e)
        {
            txt_empid.Focus();
        }
    }
}
