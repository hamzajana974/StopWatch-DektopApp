using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int miliSeconds, seconds, minutes, hours;

        private void Form1_Load(object sender, EventArgs e)
        {
            showTime();
        }
        public void showTime()
        {
            lblhr.Text = hours.ToString("00");
            lblmin.Text = minutes.ToString("00");
            lblsec.Text = seconds.ToString("00");
            lblMiliSec.Text = miliSeconds.ToString("00");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            incrementmiliSec();
            showTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miliSeconds = 0;
            seconds = 0;
            minutes = 0;
            hours = 0;
            lblhr.Text = "00";
            lblmin.Text = "00";
            lblsec.Text = "00";
            lblMiliSec.Text = "00";
        }
        public void incrementmiliSec()
        {
            if (miliSeconds == 9)
            {
                incrementSec();
                miliSeconds = 0;
            }
            else
            {
                miliSeconds++;
            }
        }

        public void incrementSec()
        {
            if (seconds == 59)
            {
                incrementMin();
                seconds = 0;
            }
            else
            {
                seconds++;
            }
        }

        public void incrementMin()
        {
            if (minutes == 59)
            {
                incrementHr();
                minutes = 0;
            }
            else
            {
                minutes++;
            }
        }
        public void incrementHr()
        {
            hours++;
        }
    }

}
