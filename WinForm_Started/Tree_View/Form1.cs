using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tree_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTreeView();
        }
        void LoadTreeView()
        {
            treeView1.CheckBoxes = true;
            #region Root1
            TreeNode root1 = new TreeNode();
            root1.Text = "Root 1";
            treeView1.Nodes.Add(root1);
                TreeNode node1 = new TreeNode() { Text = "Node con 1" };
                root1.Nodes.Add(node1);
                node1.Checked = true;
                        TreeNode nodec1 = new TreeNode() { Text = "Node cháu 1" };
                        node1.Nodes.Add(nodec1);
                        TreeNode nodec2 = new TreeNode() { Text = "Node cháu 2" };
                        node1.Nodes.Add(nodec2);
                        TreeNode nodec3 = new TreeNode() { Text = "Node cháu 3" };
                        node1.Nodes.Add(nodec3);

            TreeNode node2 = new TreeNode() { Text = "Node con 2" };
                root1.Nodes.Add(node2);
                TreeNode node3 = new TreeNode() { Text = "Node con 3" };
                root1.Nodes.Add(node3);

            #endregion
            TreeNode root2 = new TreeNode();
            root2.Text = "Root 2";
            treeView1.Nodes.Add(root2);
            TreeNode root3 = new TreeNode();
            root3.Text = "Root 3";
            treeView1.Nodes.Add(root3);
            TreeNode root4 = new TreeNode();
            root4.Text = "Root 4";
            treeView1.Nodes.Add(root4);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            e.Node.Checked = !e.Node.Checked;
        }
    }
}
