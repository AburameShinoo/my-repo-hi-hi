using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureGUI
{
    public partial class Form1 : Form
    {
        string extention = ".jpg";
        public Form1()
        {
            InitializeComponent();
            LoadImageName();
        }
        void LoadImageName()
        {
            List<string> ListName = new List<string>() { "1", "2", "3", "4", "5"};
            cbb1.DataSource = ListName;
        }

        private void cbb1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cbb1.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + cbb1.SelectedValue.ToString() + extention);
                pb1.Image = bm;
                pb1.SizeMode = PictureBoxSizeMode.Zoom;
            }    
        }
    }
}
