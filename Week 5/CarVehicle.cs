using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class CarVehicle : BaseVehicle
    {
        // overriding the StartEngine() method from the BaseVehicle abstract class
        // this shows how a car engine starts
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        // overriding the StopEngine() method from the BaseVehicle abstract class
        // this shows how a car engine stops
        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}
