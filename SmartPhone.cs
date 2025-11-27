using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone: {Brand}, Price: {Price}");
        }

        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera enabled.");
        }
    }
}
