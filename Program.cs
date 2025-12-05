using System;

namespace Workshop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            Console.WriteLine("Task 1: Expression Bodied Members\n");
            Rectangle rect = new Rectangle(10, 5);
            Console.WriteLine($"Area: {rect.Area}");
            Console.WriteLine($"Perimeter: {rect.GetPerimeter()}");



            // TASK 2
            Console.WriteLine("\nTask 2: Custom Delegates\n");
            DelegateTasks.RunDelegateDemo();



            // TASK 3
            Console.WriteLine("\nTask 3: Built-in Func Delegate\n");
            FuncProcessor.RunFuncDemo();



            // TASK 4
            Console.WriteLine("\nTask 4: LINQ Basics\n");
            LINQBasics.RunLINQBasicDemo();



            // TASK 5
            Console.WriteLine("\nTask 5: LINQ Aggregation & Quantifiers\n");
            LINQAdvanced.RunAdvancedDemo();



            // TASK 6
            Console.WriteLine("\nTask 6: LINQ Tour Booking Case Study\n");
            TourBookingLINQ.RunTourDemo();
        }
    }
}
