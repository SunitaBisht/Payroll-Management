using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Payroll
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        //Global Variable
        private bool _dragging = false;
      //  private Point _offset;
        private Point _start_point = new Point(0,0);
        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y); 
        }

        private void Welcome_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if(_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        SpeechSynthesizer spsy = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Show();
            pb.ClearContent();
            spsy.SelectVoiceByHints(VoiceGender.Female,VoiceAge.Child);
            pb.AppendText("Hello Admin , Welcome To the Payroll Management System ! Please Double Click to Log into the System.");
            spsy.Speak(pb);
        }

        private void Welcome_DoubleClick(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
