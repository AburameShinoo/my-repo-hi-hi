using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LingQGUI
{
    public partial class Form1 : Form
    {
        List<Food> foodList;
        public Form1()
        {
            InitializeComponent();
            LoadFood();
        }
        void LoadFood()
        {
            foodList = new List<Food>();
            foodList.Add(new Food("Vú dê nướng", "50000"));
            foodList.Add(new Food("Cánh gà chiên", "40000"));
            foodList.Add(new Food("Ếch xào xả ớt", "60000"));
            foodList.Add(new Food("Cá sấu nằm rơm", "80000"));
            foodList.Add(new Food("Lẩu cua đồng", "120000"));
            foodList.Add(new Food("Lẩu Thái hải sản", "200000"));
            comboBoxData.DataSource = foodList;
            comboBoxData.DisplayMember = "Name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Food> result = new List<Food>();

            foreach (Food item in foodList)
            {
                if(textBox1.Text == item.Name)
                {
                    result.Add(item);
                }
                //MessageBox.Show("Không tìm thấy");
            }
            comboBoxResult.DataSource = result;
            comboBoxResult.DisplayMember = "Name";
        }
    }

    public class Food
    {
        //private string price;
        //private string name;
        public string Name
        {
            //get { return name; }
            //set { name = value; }
            get;
            set;
        }

        public string Price 
        {
            //get { return price; }
            //set { price = value; }
            get;
            set;
        }
        public Food()
        {

        }
        public Food(string Name, string Price)
        {
            //this.Name = name;
            //this.Price = price;
            this.Name = Name;
            this.Price = Price;
        }

        
    }
}
