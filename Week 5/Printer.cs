using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    public class Printer
    {
        // method that prints a string message
        public void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // method that prints a number
        public void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // method that prints a message multiple times
        public void Print(string message, int count)
        {
            // using for loop to repeat the message
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
