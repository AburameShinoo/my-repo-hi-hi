using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuTripGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(bt2,"Hãy nhấn vào đây");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            string str = cbb1.SelectedItem.ToString();
            lb1.Text = str;
        }

        private void openLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã Click vào!");
            //openLocalToolStripMenuItem.Image = new Bitmap()
        }
    }
 }
