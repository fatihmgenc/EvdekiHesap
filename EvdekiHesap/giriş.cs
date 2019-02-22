using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvdekiHesap
{
    public partial class giriş : Form
    {
        public giriş()
        {
            InitializeComponent();
        }
        AnaForm anaForm = new AnaForm();

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Para Sesi Efekti.mp3";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            anaForm.Show();
            this.Hide();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void giriş_Load(object sender, EventArgs e)
        {
           
        }
    }
}
