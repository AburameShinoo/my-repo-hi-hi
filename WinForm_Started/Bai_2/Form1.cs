using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Thông báo nè", "Bảng thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã chọn Yes!");
            } 
            else
            {
                if(result == System.Windows.Forms.DialogResult.No)
                {
                    MessageBox.Show("Bạn đã chọn No!");
                }    
                else
                {

                }    
            }    
        }
    }
}
