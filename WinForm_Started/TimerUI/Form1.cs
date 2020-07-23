﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
            {
                timer1.Start();
                button1.Text = "Stop";
            } 
            else
            {
                timer1.Stop();
                button1.Text = "Start";
            }    
            
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            timer1.Interval = 1000;
        }
    }
}
