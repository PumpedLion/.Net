using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
        public delegate int Calculate(int a, int b);
        public delegate double DiscountStrategy(double price);

        internal class DelegateTasks
        {
            public static int Add(int a, int b) => a + b;
            public static int Subtract(int a, int b) => a - b;

            public static double FestivalDiscount(double price) => price * 0.8;
            public static double SeasonalDiscount(double price) => price * 0.9;
            public static double NoDiscount(double price) => price;

            public static double CalculateFinalPrice(double original, DiscountStrategy strategy)
                => strategy(original);

            public static void RunDelegateDemo()
            {
                // custom delegate examples
                Calculate c1 = Add;
                Calculate c2 = Subtract;

                Console.WriteLine("Add: " + c1(10, 5));
                Console.WriteLine("Subtract: " + c2(10, 5));

                Console.WriteLine("\nDiscount Strategies:");
                Console.WriteLine("Festival: " + CalculateFinalPrice(1000, FestivalDiscount));
                Console.WriteLine("Seasonal: " + CalculateFinalPrice(1000, SeasonalDiscount));
                Console.WriteLine("No Discount: " + CalculateFinalPrice(1000, NoDiscount));

                Console.WriteLine("Lambda 30%: " + CalculateFinalPrice(1000, p => p * 0.7));
            }
        }
    }
