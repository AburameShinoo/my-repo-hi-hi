using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

           
        }
        void Demo()
        {
            bool checker;
            checker = int.TryParse(textBox1.Text, out int j);
            if (checker == false || textBox1.Text == "")
            {
                MessageBox.Show("Bạn đã nhập sai!");
            }
            else
            {

                for (int i = 0; i <= j; i++)
                {
                    label1.Text = i.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(Demo);
            Thread thr = new Thread(threadStart);
            thr.IsBackground = true;
            thr.Start();
        }
        int speed = 100;
        private void button2_Click(object sender, EventArgs e)
        {
            Thread thr2 = new Thread(Demo2);
            thr2.IsBackground = true;
            thr2.Start();
            Thread.Sleep(speed);
        }
        void Demo2()
        {
            
            while (true)
            {
                if (checkBox1.Checked)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                }
                else
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                }
            }    
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBox2.Text, out speed))
            {

            }    
        }
    }
}
