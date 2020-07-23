using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusBarGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStatusBar();
        }
        void LoadStatusBar()
        {
            var label1 = new ToolStripLabel() { Name = "Label1", Text = "Status" };
            statusStrip1.Items.Add(label1);
            
        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
