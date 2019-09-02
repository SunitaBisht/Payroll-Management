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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Welcome wl = new Welcome();
            wl.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "pass123")
            {
                Home hm = new Home();
                hm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password", MessageBoxIcon.Error.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            //Home hm = new Home();
            //hm.Show();
            //this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

        }
    }
}
