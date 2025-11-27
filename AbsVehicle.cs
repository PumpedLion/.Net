using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public abstract class AbsVehicle
    {
        public void Display()
        {
            Console.WriteLine("This is vehicle");
        }

        public abstract void StartEngine();
        public abstract void StopEngine();
    }
}
