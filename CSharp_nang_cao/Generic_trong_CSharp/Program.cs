using System;
using System.Collections;
using System.Data;
using System.Text;

namespace Generic_trong_CSharp
{
    class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            double c, d;
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Mời bạn nhập vào số a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập vào số b: ");
            b = int.Parse(Console.ReadLine());
            Swap<int>(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.ReadKey();
        }
    }
}
