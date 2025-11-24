using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // Smartphone class inherits from ElectronicDevice
    public class Smartphone : ElectronicDevice
    {
        // constructor: passing brand and price to the parent (ElectronicDevice) constructor
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        // overriding the abstract ShowInfo() method from ElectronicDevice
        // this will display smartphone details
        public override void ShowInfo()
        {
            Console.WriteLine("Smartphone Information:");
            Console.WriteLine("Brand: " + Brand);  // printing the phone brand
            Console.WriteLine("Price: $" + Price); // printing the phone price
            Console.WriteLine("-----------------------------");
        }
    }
}
