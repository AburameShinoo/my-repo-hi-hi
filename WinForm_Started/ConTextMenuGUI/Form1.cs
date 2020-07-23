using System;
using System.Windows.Forms;

namespace ConTextMenuGUI
{
    public partial class Form1 : Form
    {
        ContextMenuStrip contextMenu;
        ToolStripButton item1;
        ToolStripButton item2;
        ToolStripButton item3;
        public Form1()
        {
            InitializeComponent();
            LoadContextMenu();
            item1.Click += Item1_Click;
            item2.Click += Item2_Click;
            item3.Click += Item3_Click;
        }

        

        void LoadContextMenu()
        {
            contextMenu = new ContextMenuStrip();
            item1 = new ToolStripButton() { Text = "Refresh" };
            contextMenu.Items.Add(item1);
            item2 = new ToolStripButton() { Text = "Copy" };
            contextMenu.Items.Add(item2);
            item3 = new ToolStripButton() { Text = "Paste" };
            contextMenu.Items.Add(item3);
        }
        private void Item1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa mới Click Refresh");
        }
        private void Item2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa mới Click Copy");
        }
        private void Item3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa mới Click Paste");
        }
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //contextMenu.Show(this, this.PointToClient(MousePosition));
                textBox1.ContextMenuStrip = contextMenu;
            }
        }
    }
}
