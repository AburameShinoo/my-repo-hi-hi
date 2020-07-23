using System;
using System.Collections;
using System.Text;

namespace BitArray_trong_CSharp
{
    class Program
    {
        public static void PrintBit(BitArray BitBA, int Width) //Width là số Bit bạn muốn hiện thị trên 1 dòng. Ví dụ 1 = 10000000
        {
            
            int i = Width;
            foreach(bool iteam in BitBA)
            {
                if(i < 1)
                {
                    i = Width; // Khi i = 0 ta cần nạp lại i = Width để nó viết tiếp một dòng mới.
                    Console.WriteLine("");
                }
                else
                {
                    i--;
                    Console.Write(iteam.GetHashCode());
                }
            }    
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ///*
            // * Khởi tạo 1 BitArray có 10 phần tử. 
            // * Mỗi phần tử có giá trị mặc định 0 (false).
            //*/
            //BitArray MyBA = new BitArray(10);
            ///*
            // * Khởi tạo 1 BitArray có 10 phần tử. 
            // * Mỗi phần tử có giá trị mặc định 1 (true).
            // */
            //BitArray MyBA2 = new BitArray(10, true);
            ///*
            // * Khởi tạo 1 BitArray từ một mảng bool có sẵn.
            // */
            //bool[] MyBools = new bool[5] { true, false, true, true, false };
            //BitArray MyBA3 = new BitArray(MyBools); // 1 0 1 1 0
            ///*
            // * Khởi tạo 1 BitArray từ một mảng byte có sẵn.
            // */
            //byte[] MyBytes = new byte[5] { 1, 2, 3, 4, 5 };
            //BitArray MyBA4 = new BitArray(MyBytes);

            /*
            * Khởi tạo 1 BitArray từ một mảng int có sẵn.
            */
            byte[] MyBytes = new byte[5] { 1, 2, 3, 4, 5 };
            BitArray MyBA5 = new BitArray(MyBytes);
            Console.WriteLine("Số phần tử của MyBA5 là: {0}:", MyBA5.Count);
            PrintBit(MyBA5, 8);
            Console.ReadKey();


        }
    }
}
