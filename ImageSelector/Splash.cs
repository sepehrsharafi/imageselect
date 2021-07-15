using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DarkUI.Forms;

namespace ImageSelector
{
    public partial class Splash : DarkForm
    {
        Timer tmr;
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec
            tmr.Interval = 3000;

            //starts the timer
            tmr.Start();

            tmr.Tick += tmr_Tick;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            //after 3 sec stop the timer
            tmr.Stop();

            //display mainform
            frmImageSelector frm = new frmImageSelector();
            frm.Show();

            //hide this form
            this.Hide();

        }
    }
}