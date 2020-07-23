using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_trong_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Dictionary<string, string> MyDic = new Dictionary<string, string>();
            MyDic.Add("GT", "GettingStarted");
            MyDic.Add("FR", "Free Education");
            MyDic.Add("HK", "HowKteam.com");
            Console.WriteLine("----Duyệt Dictionary vừa tạo-----");
            Console.WriteLine("Số phần tử hiện có trong Dic: {0}", MyDic.Count);
            foreach(KeyValuePair<string, string> iteam in MyDic)
            {
                Console.WriteLine(iteam.Key + "\t" + iteam.Value);
            }
            Console.ReadKey();
        }
    }
}
