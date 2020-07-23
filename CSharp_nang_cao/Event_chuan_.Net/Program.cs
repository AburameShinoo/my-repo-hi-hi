using System;
using System.Collections.Generic;
using System.Text;

namespace Event_chuan_.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
        }
    }
    class HocSinh
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set
            {
                Name = value;
            }
        }

    }
}
