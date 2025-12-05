using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class LINQBasics
    {
        public static void RunLINQBasicDemo()
        {
            // square numbers
            var nums = new List<int> { 1, 2, 3, 4, 5 };
            var squared = nums.Select(n => n * n);

            Console.WriteLine("Squared Numbers:");
            foreach (var s in squared) Console.WriteLine(s);

            // premium books
            var books = new List<Book>
            {
                new Book("C# Basics", 800),
                new Book("Advanced LINQ", 1500),
                new Book("ASP.NET", 1200)
            };

            var premium = books.Where(b => b.Price > 1000);

            Console.WriteLine("\nPremium Books:");
            foreach (var b in premium) Console.WriteLine(b.Title);

            // sort students
            var students = new List<Student>
            {
                new Student("Alzeena"),
                new Student("Namsang"),
                new Student("Soniya")
            };

            var sorted = students.OrderBy(s => s.Name);

            Console.WriteLine("\nSorted Students:");
            foreach (var s in sorted) Console.WriteLine(s.Name);
        }
    }

    internal class Book
    {
        public string Title;
        public double Price;

        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }
    }

    internal class Student
    {
        public string Name;
        public Student(string name) { Name = name; }
    }
}

