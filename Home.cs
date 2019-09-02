using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addemp obj = new addemp();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search se = new search();
            se.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            BasicSalary bs = new BasicSalary();
            bs.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bonus bo = new Bonus();
            bo.Show();
            this.Hide();
        }

        private void btnincentives_Click(object sender, EventArgs e)
        {
            incentives incen = new incentives();
            incen.Show();
            this.Hide();
        }

        private void btndeduction_Click(object sender, EventArgs e)
        {
            deduction ded = new deduction();
            ded.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update up = new Update();
            up.Show();
            //this.Hide();
        }

        private void showEmployeeIdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addemp obj = new addemp();
            obj.Show();
            //this.Hide();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            NetSalary ns = new NetSalary();
            ns.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update p = new Update();
            p.Show();
        }

        private void basicSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicSalary bs = new BasicSalary();
            bs.Show();
        }

        private void incentivesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incentives inc = new incentives();
            inc.Show();
        }

        private void bonusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bonus bo = new Bonus();
            bo.Show();
        }

        private void deductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deduction du = new deduction();
            du.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search se = new search();
            se.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
