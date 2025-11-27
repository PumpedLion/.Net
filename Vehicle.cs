using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class Vehicle
    {
        public string Brand { get; set; } = "";
        public int Speed { get; set; }

        public void Start() => Console.WriteLine("Vehicle started");
        public void Stop() => Console.WriteLine("Vehicle stopped");

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}");
        }
    }
}
