using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    // Simple beginner calculator class
    class Calculator
    {
        public void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator");
        }

        public int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int Multiply(int num1, int num2 = 1)
        {
            int result = num1 * num2;
            return result;
        }
    }
}
