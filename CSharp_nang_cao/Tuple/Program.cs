using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace Tuple_trong_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var MyTuple = Tuple.Create<int, string>(1, "HowKteam");
            var MyTuple2 = new Tuple<int, string>(2, "Free Education");
            
        }
        static Tuple<int, int, int> GetTimeDayMonthYear()
        {
            DateTime now = DateTime.Now;
            return new Tuple<int, int, int>(now.Day, now.Month, now.Year);
         
        }
    }
}
