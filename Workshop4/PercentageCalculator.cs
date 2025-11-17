using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    class PercentageCalculator
    {
        public void RunPercentageProgram()
        {
            Console.WriteLine("=== Task 6: Debugging Percentage Program ===");

            Console.Write("Enter marks (integer): ");
            string marksInput = Console.ReadLine();

            Console.Write("Enter total marks (integer): ");
            string totalInput = Console.ReadLine();

            bool isMarksOk = int.TryParse(marksInput, out int marks);
            bool isTotalOk = int.TryParse(totalInput, out int total);

            if (!isMarksOk || !isTotalOk)
            {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            }
            else if (total <= 0)
            {
                Console.WriteLine("Total must be greater than zero.");
            }
            else
            {
                // Common bug: marks / total * 100 (integer division)
                // FIX: cast to double
                double percentage = (double)marks / total * 100;

                Console.WriteLine("Percentage = " + percentage + "%");
            }

            Console.WriteLine();
        }
    }
}
