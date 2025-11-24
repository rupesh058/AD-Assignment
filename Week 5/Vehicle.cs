using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Vehicle
    {
        // private fields to store brand name and speed
        private string brand;
        private int speed;

        // public property to get and set the brand name
        public string Brand
        {
            get { return brand; }   // return brand value
            set { brand = value; }  // set brand value
        }

        // public property to get and set speed
        public int Speed
        {
            get { return speed; }   // return speed value
            set { speed = value; }  // set speed value
        }

        // method to show that the vehicle is starting
        public void Start()
        {
            Console.WriteLine($"{brand} is starting...");
        }

        // method to show that the vehicle is stopping
        public void Stop()
        {
            Console.WriteLine($"{brand} is stopping...");
        }

        // virtual method so child classes (Car, MotorCycle) can override this method
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}");          // printing brand
            Console.WriteLine($"Speed: {speed} km/h");     // printing speed
        }
    }
}
