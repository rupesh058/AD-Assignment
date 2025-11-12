using System;
using System.Collections.Generic;

namespace Week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== WEEK 2 WORKSHOP ==========");

            Task1_Variables();
            Task2_Constants();
            Task3_DataTypesAndConversion();
            Task4_Arrays();
            Task5_DateTimeAndTimeSpan();
            Task6_GenericCollections();
          
        }

        // --------------------- Task 1 ---------------------
        static void Task1_Variables()
        {
            Console.WriteLine("\n--- Task 1: Variables ---");
            string userName = "Rupesh";
            int luckyNumber = 10;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
        }

        // --------------------- Task 2 ---------------------
        static void Task2_Constants()
        {
            Console.WriteLine("\n--- Task 2: Constants ---");

            double radius = 5;
            Console.WriteLine($"Radius: {radius}");

            Console.WriteLine($"Area of Circle: {Circle.CalculateArea(radius)}");
            Console.WriteLine($"Perimeter of Circle: {Circle.CalculatePerimeter(radius)}");

            // Note: Trying to modify Circle.PI will cause a compile-time error
            // Circle.PI = 3.14159; // ❌ Uncommenting this will produce an error
        }

        // Circle class for Task 2
        class Circle
        {
            public const double PI = 3.14;

            public static double CalculateArea(double radius)
            {
                return PI * radius * radius;
            }

            public static double CalculatePerimeter(double radius)
            {
                return 2 * PI * radius;
            }
        }

        // --------------------- Task 3 ---------------------
        static void Task3_DataTypesAndConversion()
        {
            Console.WriteLine("\n--- Task 3: Data Types and Type Conversion ---");

            byte a = 10;
            short b = 200;
            int c = 1000;
            long d = 123456789L;
            float e = 12.34f;
            double f = 45.6789;
            decimal g = 123.456m;
            char h = 'A';
            bool i = true;

            string intToString = c.ToString();
            double stringToDouble = Convert.ToDouble("3.14");

            Console.WriteLine($"byte: {a}, short: {b}, int: {c}, long: {d}");
            Console.WriteLine($"float: {e}, double: {f}, decimal: {g}");
            Console.WriteLine($"char: {h}, bool: {i}");
            Console.WriteLine($"int to string: {intToString}, string to double: {stringToDouble}");
        }

        // --------------------- Task 4 ---------------------
        static void Task4_Arrays()
        {
            Console.WriteLine("\n--- Task 4: Array and Array Methods ---");

            int[] favNumbers = { 9, 4, 7, 2, 5 };

            Console.WriteLine("Original Array: " + string.Join(", ", favNumbers));

            Array.Sort(favNumbers);
            Console.WriteLine("Sorted Array: " + string.Join(", ", favNumbers));

            Array.Reverse(favNumbers);
            Console.WriteLine("Reversed Array: " + string.Join(", ", favNumbers));

            int index = Array.IndexOf(favNumbers, 7);
            Console.WriteLine($"Index of 7: {index}");
        }

        // --------------------- Task 5 ---------------------
        static void Task5_DateTimeAndTimeSpan()
        {
            Console.WriteLine("\n--- Task 5: DateTime and TimeSpan ---");

            DateTime birthDate = new DateTime(2002, 3, 17);
            DateTime currentDate = DateTime.Now;

            TimeSpan ageSpan = currentDate - birthDate;
            int ageYears = (int)(ageSpan.Days / 365.25);

            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age: {ageYears} years old");

            DateTime futureDate = birthDate.AddDays(10);
            Console.WriteLine($"10 days after birthdate: {futureDate.ToShortDateString()}");
        }

        // --------------------- Task 6 ---------------------
        static void Task6_GenericCollections()
        {
            Console.WriteLine("\n--- Task 6: Generic Collections (List & Dictionary) ---");

            List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Banana");

            Console.WriteLine("Fruits List:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                {1, "Mango"},
                {2, "Apple"},
                {3, "Orange"}
            };

            fruitDict.Add(4, "Pineapple");

            Console.WriteLine("\nFruit Dictionary:");
            foreach (var kvp in fruitDict)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }
        }
    }
}
