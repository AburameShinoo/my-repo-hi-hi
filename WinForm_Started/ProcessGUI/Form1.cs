using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void GetProcess()
        {
            Process[] processArr = Process.GetProcesses();
            foreach (Process item in processArr)
            {
                textBox1.Text = item.ProcessName + "\n" + textBox1.Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"www.google.com");
        }
    }
}
