using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    class ParameterDemo
    {
        // ref example
        public void Increase(ref int number)
        {
            number = number + 10;
        }

        // out example
        public void GetFullName(out string fullName)
        {
            fullName = "Rupesh Dahal";
        }

        // params example
        public int SumAll(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;
        }
    }
}
