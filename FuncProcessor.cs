using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class FuncProcessor
    {
        public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var n in numbers)
            {
                if (condition(n))
                    Console.WriteLine(n);
            }
        }

        public static void RunFuncDemo()
        {
            int[] nums = { 1, 5, 12, 18, 9 };

            Console.WriteLine("Even Numbers:");
            ProcessNumbers(nums, n => n % 2 == 0);

            Console.WriteLine("\nGreater than 10:");
            ProcessNumbers(nums, n => n > 10);
        }
    }
}

