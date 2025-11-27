using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class AbsCar : AbsVehicle
    {
        public override void StartEngine() => Console.WriteLine("Car engine has started");
        public override void StopEngine() => Console.WriteLine("Car engine has stopped");
    }


}
