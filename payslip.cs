using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Payroll
{
    public partial class payslip : Form
    {
        public payslip()
        {
            InitializeComponent();
        }
        
        private void btncalc_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void payslip_Load(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Bitmap bitmap;
        private void button3_Click(object sender, EventArgs e)
        {
            //Add a Panel control
            Panel panel = new Panel();
            this.Controls.Add(panel);

            //Create a bitmap of size same as that of the form
            Graphics graphic = panel.CreateGraphics();
            Size formsize = this.ClientSize;
            bitmap = new Bitmap(formsize.Width, formsize.Height, graphic);
            graphic = Graphics.FromImage(bitmap);

            //Copy the screen area that the panel covers
            Point panel_location = PointToScreen(panel.Location);
            graphic.CopyFromScreen(panel_location.X, panel_location.Y, 0, 0, formsize);

            //Show the print preview dialog
            printPreviewDialog1.Document = printDocument1;
           // printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            this.Close();     
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
           // Print the content
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
