using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop: {Brand}, Price: {Price}");
        }

        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery has turned on.");
        }
    }
}
