using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }
        ImageList imgListSmall;
        ImageList imgListLarge;
        void LoadImageList()//Tạo một thuộc tính ảnh Icon
        {
            imgListLarge = new ImageList();
            imgListSmall = new ImageList();
            imgListLarge.ImageSize = new Size(72, 72);
            imgListLarge.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\Folder.png"));
            imgListSmall.ImageSize = new Size(16, 16);
            imgListSmall.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\Folder.png"));

        }
        void LoadListView()
        {
            LoadImageList();
            //Thêm đường kẻ
            lv1.GridLines = true;
            //Thêm thuộc tính chọn nguyên hàng
            lv1.FullRowSelect = true;
            //Thêm cột vào ListView
            lv1.Columns.Add("Tên Columns 1");
            lv1.Columns.Add("Tên Columns 2");
            lv1.Columns.Add("Tên Columns 3");
            //Thêm thuộc tính ảnh Icon
            lv1.LargeImageList = imgListLarge;
            lv1.SmallImageList = imgListSmall;

            //Thêm item 1
            ListViewItem item1 = new ListViewItem();

            item1.Text = "Item 1";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SumItem 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SumItem 2" });
            item1.ImageIndex = 0;
            lv1.Items.Add(item1);

            //Thêm item 2
            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SumItem 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SumItem 2" });
            item2.ImageIndex = 0;
            lv1.Items.Add(item2);
            //Thêm item 3
            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item 3";
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SumItem 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "SumItem 3" });
            item3.ImageIndex = 0;
            lv1.Items.Add(item3);

            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            lv1.View = View.LargeIcon;
            lv1.CheckBoxes = false;//Kiểu LargeIcon không có ô checkbox
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            lv1.View = View.Details;
            lv1.CheckBoxes = true;// Chỉ khi ở kiểu Details mới có ô checkBox
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            lv1.View = View.SmallIcon;
            lv1.CheckBoxes = false;//Kiểu SmallIcon không có ô checkbox
        }
    }
}
