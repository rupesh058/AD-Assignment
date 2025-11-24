using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Car : Vehicle
    {
        // private field to store number of seats
        private int seats;

        // public property to get and set seats
        public int Seats
        {
            get { return seats; }   // returning the seats value
            set { seats = value; }  // setting the seats value
        }

        // overriding the DisplayInfo() method from Vehicle class
        public override void DisplayInfo()
        {
            // calling the base class DisplayInfo() to show common info
            base.DisplayInfo();

            // showing the extra field specific to Car
            Console.WriteLine($"Seats: {seats}");
        }
    }
}
