using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop5
{
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice d)
        {
            devices.Add(d);
        }

        public void ShowAllDeviceDetails()
        {
            foreach (var d in devices)
            {
                d.ShowInfo();

                if (d is Laptop lap)
                    lap.TurnOnBattery();

                if (d is Smartphone sp)
                    sp.EnableCamera();

            }
        }
    }
}
