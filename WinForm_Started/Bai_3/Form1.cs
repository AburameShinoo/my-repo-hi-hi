using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = new Button();
            bt.Text = "Xin chào";
            Random rnd = new Random();
            bt.Location = new Point(rnd.Next(0, pnl1.Width), rnd.Next(0, pnl1.Height));
            pnl1.Controls.Add(bt);
            fPanel.Controls.Add(bt);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pnl1.Enabled = !pnl1.Enabled;
        }
    }
}
