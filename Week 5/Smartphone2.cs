using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    // Smartphone2 is inheriting from ElectronicDevice
    public class Smartphone2 : ElectronicDevice
    {
        // Constructor — sending the brand and price to the parent class
        public Smartphone2(string brand, double price) : base(brand, price)
        {
        }

        // This is an extra method only for Smartphone2
        // It shows that the camera is being enabled
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is now enabled.");
        }

        // Overriding the abstract ShowInfo() method from ElectronicDevice
        // This prints all important details of the smartphone
        public override void ShowInfo()
        {
            Console.WriteLine("Smartphone Details:");
            Console.WriteLine("Brand: " + Brand);   // showing brand name
            Console.WriteLine("Price: $" + Price);  // showing price
            Console.WriteLine("---------------------------------");
        }
    }
}
