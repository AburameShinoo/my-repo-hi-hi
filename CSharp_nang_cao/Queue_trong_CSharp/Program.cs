using System;
using System.Collections;
using System.Text;

namespace Queue_trong_CSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Queue MyQueue = new Queue();
            Queue MyQueue2 = new Queue(5);
            ArrayList MyArray = new ArrayList();
            MyArray.Add(5);
            MyArray.Add(9);
            MyArray.Add(10);
            Queue MyQueue3 = new Queue(MyArray);
            Console.WriteLine("Số phần tử hiện tại của Queue là: {0}", MyQueue3.Count);
            Console.WriteLine("Phần tử đầu tiên của Queue là: {0}", MyQueue3.Peek());
            Console.WriteLine("-----------------Pooping-----------------");
            int lenght = MyQueue3.Count;
            for(int i = 0; i < lenght; i++)
            {
                
                    Console.Write("Phần tử số {0} là:", (i + 1));
                    Console.WriteLine(MyQueue3.Dequeue());
 
                
            }
            // Số phần tử của Queue sau khi Dequeue.
            Console.Write("Số phần tử của Queue hiện tại: {0}", MyQueue3.Count);
            Console.ReadKey();
        }
    }
}
