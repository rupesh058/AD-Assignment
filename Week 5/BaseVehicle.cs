using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public abstract class BaseVehicle
    {
        // this is an abstract method, so child classes must write their own StartEngine()
        public abstract void StartEngine();

        // another abstract method, child classes must give their own StopEngine() code
        public abstract void StopEngine();

        // this is a normal method, so child classes can directly use it without overriding
        public void Display()
        {
            // just showing a simple message
            Console.WriteLine("This is a vehicle");
        }
    }
}
