using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class Printer
    {
        public void Print(string msg) => Console.WriteLine(msg);
        public void Print(int number) => Console.WriteLine(number);
        public void Print(string msg, int count)
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(msg);
        }
    }
}
