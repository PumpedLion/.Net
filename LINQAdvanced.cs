using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class LINQAdvanced
    {
        public static void RunAdvancedDemo()
        {
            var sales = new List<CashierSales>
            {
                new CashierSales("C1", 5000),
                new CashierSales("C2", 7000),
                new CashierSales("C3", 4000)
            };

            Console.WriteLine("Total Cashiers: " + sales.Count());
            Console.WriteLine("Total Sales: " + sales.Sum(s => s.Sales));
            Console.WriteLine("Highest: " + sales.Max(s => s.Sales));
            Console.WriteLine("Lowest: " + sales.Min(s => s.Sales));
            Console.WriteLine("Average: " + sales.Average(s => s.Sales));



            // Applicants
            var applicants = new List<Applicant>
            {
                new Applicant("A", 20),
                new Applicant("B", 17),
                new Applicant("C", 25)
            };

            Console.WriteLine("\nAny under 18: " + applicants.Any(a => a.Age < 18));
            Console.WriteLine("All above 16: " + applicants.All(a => a.Age > 16));



            // Songs
            var songs = new List<Song>
            {
                new Song(180),
                new Song(250),
                new Song(300)
            };

            Console.WriteLine("\nFirst: " + songs.First().Duration);
            Console.WriteLine("Last: " + songs.Last().Duration);

            Console.WriteLine("First >4 minutes: " +
                songs.First(s => s.Duration > 240).Duration);

            var safe = songs.FirstOrDefault(s => s.Duration > 600);
            Console.WriteLine("Safe >10 min: " + (safe?.Duration.ToString() ?? "No Song"));
        }
    }

    internal class CashierSales
    {
        public string Name;
        public double Sales;
        public CashierSales(string n, double s) { Name = n; Sales = s; }
    }

    internal class Applicant
    {
        public string Name;
        public int Age;
        public Applicant(string n, int a) { Name = n; Age = a; }
    }

    internal class Song
    {
        public int Duration;
        public Song(int d) { Duration = d; }
    }
}
