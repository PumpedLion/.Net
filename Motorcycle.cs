using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class Motorcycle : Vehicle
    {
        public bool HasCarrier { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}
