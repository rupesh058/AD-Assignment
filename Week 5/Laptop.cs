using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // Laptop class is inheriting from ElectronicDevice
    public class Laptop : ElectronicDevice
    {
        // constructor: sending brand and price to the base (parent) class
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // overriding the abstract method from ElectronicDevice
        // this method shows all information about the laptop
        public override void ShowInfo()
        {
            Console.WriteLine("Laptop Information:");
            Console.WriteLine("Brand: " + Brand);  // showing brand
            Console.WriteLine("Price: $" + Price); // showing price
            Console.WriteLine("-----------------------------");
        }
    }
}
