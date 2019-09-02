using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace Payroll
{
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }
        String CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "select a.Id,a.name,a.designation,a.department,a.doj,hra,da,ta,medical,others,totalamount,salarytype,salaryamount,bonustype,bonusamount,professional_tax,advance_pay,provisional_fund,loan,DeductedByLeaves,total_deduction,ft.net_salary,ft.salary_type from addemp as a join incentives as i on a.Id = i.Id join basicsalary as b on a.Id = b.Id join bonus as bo on bo.Id = a.Id join deduction as de on de.Id = a.Id join Final_Table as ft on ft.Id = a.Id where a.Id = @Id";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", txt_search_print.Text.Trim());
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        payslip ps = new payslip();
                        //General Details....................................
                        ps.lbl_id.Text = rdr.GetValue(0).ToString();
                        ps.lbl_name.Text = rdr.GetValue(1).ToString();
                        ps.lbl_designation.Text = rdr.GetValue(2).ToString();
                        ps.lbl_department.Text = rdr.GetValue(3).ToString();
                        ps.lbl_doj.Text = rdr.GetValue(4).ToString();
                        //Incentives Details...............................................
                        ps.lbl_hra_payslip.Text = rdr.GetValue(5).ToString();
                        ps.lbl_da_payslip.Text = rdr.GetValue(6).ToString();
                        ps.lbl_ta_payslip.Text = rdr.GetValue(7).ToString();
                        ps.lbl_medical_payslip.Text = rdr.GetValue(8).ToString();
                        ps.lbl_others_payslip.Text = rdr.GetValue(9).ToString();
                        ps.txt_GrossIncentives.Text = rdr.GetValue(10).ToString();
                        //Salary Details........................................................
                        ps.lbl_salary_type.Text = rdr.GetValue(11).ToString();
                        ps.txt_basicSalary.Text = rdr.GetValue(12).ToString();
                        //Bonus Details...........................................................
                        ps.lbl_bonusType.Text = rdr.GetValue(13).ToString();
                        ps.txt_grossBonus.Text = rdr.GetValue(14).ToString();
                        //Deduction Details........................................................
                        ps.lbl_professional_tax.Text = rdr.GetValue(15).ToString();
                        ps.lbl_advanced_pay.Text = rdr.GetValue(16).ToString();
                        ps.lbl_provisional.Text = rdr.GetValue(17).ToString();
                        ps.lbl_loan.Text = rdr.GetValue(18).ToString();
                        ps.txt_leaveDeduction.Text = rdr.GetValue(19).ToString();
                        ps.txt_grossDeduction.Text = rdr.GetValue(20).ToString();
                        ps.txt_netsalary.Text = rdr.GetValue(21).ToString();
                        ps.lbl_netsalaryType.Text = rdr.GetValue(22).ToString();
                        con.Close();
                        ps.Show();
                        this.Hide();
                        ps.Refresh();
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong Input. Please provide Correct information!");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Load(object sender, EventArgs e)
        {
            txt_search_print.Focus();
        }
    }

}



