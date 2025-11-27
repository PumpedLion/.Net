using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class AbsBike : AbsVehicle
    {
        public override void StartEngine() => Console.WriteLine("Bike engine has started");
        public override void StopEngine() => Console.WriteLine("Bike engine has stopped");
    }
}
