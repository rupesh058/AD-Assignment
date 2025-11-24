using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // MotorCycle class is inheriting from Vehicle class
    public class MotorCycle : Vehicle
    {
        // private field for checking if motorcycle has a carrier
        private bool hasCarrier;

        // public property to get and set the carrier value
        public bool HasCarrier
        {
            get { return hasCarrier; }   // returns true/false
            set { hasCarrier = value; }  // sets true/false
        }

        // overriding DisplayInfo() method from Vehicle
        public override void DisplayInfo()
        {
            // calling base class method to show common info first
            base.DisplayInfo();

            // showing the motorcycle-specific information
            Console.WriteLine($"Has Carrier: {hasCarrier}");
        }

    }
}
