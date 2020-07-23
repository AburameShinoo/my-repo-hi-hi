using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComBoBoxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<CBClass> ListClass = new List<CBClass>();
            ListClass.Add(new CBClass()
            {
                ClassName = "12A1",
                ListStudent = new List<string> { "Nguyễn Anh Dũng", "Lều Vũ Đức", "Võ Kế Tín", "Nguyễn Hữu Định", "Phan Long Cường" }

            });
            ListClass.Add(new CBClass()
            {
                ClassName = "12A2",
                ListStudent = new List<string> { "Nguyễn Tấn Lực", "Mã Thị Luận", "Ngô Đức Hoàng Vũ", "Phạm Huy Tín", "Huỳnh Trân Bảo Ngọc" }

            });
            cbb2.DataSource = ListClass;
            cbb2.DisplayMember = "ClassName";
        }
        List<Food> ListIteam;
        private void bt1_Click(object sender, EventArgs e)
        {
            ListIteam = new List<Food>()
            {
                new Food() {Name = "Mực một nắng", Price = 200000},
                new Food() {Name = "Ếch xào xả ớt", Price = 100000},
                new Food() {Name = "Thịt chó", Price = 12000}
            };
            cbb1.DataSource = ListIteam;
            cbb1.DisplayMember = "Name";
        }
        
        private void cbb1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            Food fd = cb.SelectedItem as Food;
            tb1.Text = fd.Price.ToString();
        }

        private void cbb2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            //if(cb.SelectedIndex != null)
            //{
                CBClass cbc = cb.SelectedItem as CBClass;
                cbb3.DataSource = cbc.ListStudent;
            //}    
            
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public class CBClass
    {
        public string ClassName { get; set; }
        public List<string> ListStudent { get; set; }

    }
}
