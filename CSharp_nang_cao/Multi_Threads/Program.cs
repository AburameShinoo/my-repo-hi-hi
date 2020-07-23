using System;
using System.Text;
using System.Threading;
using System.Text;

namespace Multi_Threads
{
    class Program
    {
        static void DemoThread(string threadIndex) // Tạo hàm hoặc phương thức
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(threadIndex + "-" + i);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            for(int i = 0; i < 10; i++)
            {
                int BienTrungGian = i;
                Thread t = new Thread(() => { DemoThread("Thread" + BienTrungGian); });
                t.IsBackground = true;
                t.Start();
            }
            Console.ReadKey();

        }
        
    }
}
