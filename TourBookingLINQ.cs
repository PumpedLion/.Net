using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class TourBookingLINQ
    {
        public static void RunTourDemo()
        {
            var list = new List<Booking>
            {
                new Booking("Saina", "Pokhara", 6000, 3, false),
                new Booking("Numa", "Thailand", 35000, 5, true),
                new Booking("Ningsha", "UK", 150000, 10, true)
            };

            var filtered = list.Where(t => t.Price > 10000 && t.Duration > 4);

            var projected = filtered.Select(t => new
            {
                t.CustomerName,
                t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                t.Price
            });

            var sorted = projected
                .OrderBy(p => p.Category)
                .ThenBy(p => p.Price);

            Console.WriteLine("\nTour Summary Report:");
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.CustomerName} | {item.Destination} | {item.Category} | Rs.{item.Price}");
            }
        }
    }

    internal class Booking
    {
        public string CustomerName;
        public string Destination;
        public double Price;
        public int Duration;
        public bool IsInternational;

        public Booking(string c, string d, double p, int days, bool intl)
        {
            CustomerName = c;
            Destination = d;
            Price = p;
            Duration = days;
            IsInternational = intl;
        }
    }
}