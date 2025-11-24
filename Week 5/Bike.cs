using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Bike : BaseVehicle
    {
        // overriding the abstract StartEngine() from BaseVehicle
        // this is how a bike starts its engine
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started.");
        }

        // overriding the abstract StopEngine()
        // this shows how a bike stops its engine
        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped.");
        }
    }
}
