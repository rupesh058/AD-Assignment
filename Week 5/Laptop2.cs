using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // Laptop2 is also a type of ElectronicDevice because it inherits from it
    public class Laptop2 : ElectronicDevice
    {
        // Constructor — sending brand and price values to the parent class
        public Laptop2(string brand, double price) : base(brand, price)
        {
        }

        // This is an extra method only Laptop2 has
        // It shows that the laptop battery is being turned on
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is now ON.");
        }

        // Overriding the abstract ShowInfo() method from ElectronicDevice
        // Here we print all the details of this Laptop2 object
        public override void ShowInfo()
        {
            Console.WriteLine("Laptop Details:");
            Console.WriteLine("Brand: " + Brand);   // showing brand name
            Console.WriteLine("Price: $" + Price);  // showing price
            Console.WriteLine("---------------------------------");
        }
    }
}
