using System;
using System.Collections.Generic;
using System.Text;

namespace List_trong_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //List<int> MyList = new List<int>();
            //List<int> MyList2 = new List<int>(5);
            //List<int> MyList3 = new List<int>(MyList);
            List<String> MyList = new List<string>();
            MyList.Add("Free Education");
            MyList.Add("HowKteam.com");
            MyList.Add("Hello");
            Console.WriteLine("------------Duyệt List vừa tạo----------------");
            Console.WriteLine("Số phần tử trong List: {0}", MyList.Count);
            foreach(string iteam in MyList)
            {
                Console.WriteLine("- " + iteam);
            }
            Console.WriteLine();
            //Chèn một phần tử vào đầu List:
            MyList.Insert(0, "Gettingstarted");
            Console.WriteLine("------------Duyệt List vừa chèn----------------");
            Console.WriteLine("Số phần tử trong List: {0}", MyList.Count);
            foreach (string iteam in MyList)
            {
                Console.WriteLine("- " + iteam);
            }
            Console.WriteLine();
            Console.ReadKey();
            //Kiểm tra một phần tử có tồn tại trong List hay không?
            string MyString;
            Console.WriteLine("Mời bạn nhập vào chuỗi cần tìm kiếm trong List:");
            MyString = Console.ReadLine();
            if(MyList.Contains(MyString) == false)
            {
                Console.WriteLine("Phần tử \"{0}\" không tồn tại trong List!", MyString);
            }    
            else
            {
                Console.WriteLine("Phần tử \"{0}\" có tồn tại trong List!", MyString);
            }
            Console.ReadKey();
        }
    }
}
