namespace Workshop4
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // Task 1 - Student
            // =======================
            Console.WriteLine("=== Task 1: Student ===");

            Student s1 = new Student();
            s1.Name = "Anmol";
            s1.Age = 22;
            s1.Id = "S001";

            Student s2 = new Student();
            s2.Name = "Rupesh";
            s2.Age = 24;
            s2.Id = "S002";

            Console.WriteLine("Student 1: " + s1.Name + ", " + s1.Age + ", " + s1.Id);
            Console.WriteLine("Student 2: " + s2.Name + ", " + s2.Age + ", " + s2.Id);
            Console.WriteLine("School: " + Student.SchoolName);
            Console.WriteLine();

            // =======================
            // Task 2 - Calculator
            // =======================
            Console.WriteLine("=== Task 2: Calculator ===");

            Calculator calc = new Calculator();
            calc.PrintWelcome();

            int sum = calc.Add(10, 5);
            Console.WriteLine("Addition = " + sum);

            int multi1 = calc.Multiply(4, 3);
            Console.WriteLine("Multiply = " + multi1);

            int multi2 = calc.Multiply(7);
            Console.WriteLine("Multiply (default) = " + multi2);
            Console.WriteLine();

            // =======================
            // Task 3 - Parameter Types
            // =======================
            Console.WriteLine("=== Task 3: Parameter Types ===");

            ParameterDemo p = new ParameterDemo();

            int number = 5;
            Console.WriteLine("Original number: " + number);
            p.Increase(ref number);
            Console.WriteLine("After Increase: " + number);

            string fullName;
            p.GetFullName(out fullName);
            Console.WriteLine("Full Name: " + fullName);

            int totalSum = p.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine("SumAll = " + totalSum);
            Console.WriteLine();

            // =======================
            // Task 4 - Constructors
            // =======================
            Console.WriteLine("=== Task 4: Constructors ===");

            Player p1 = new Player(); // default
            p1.PrintPlayerInfo();

            Player p2 = new Player("The Legend", 10, 250); // parameterized
            p2.PrintPlayerInfo();
            Console.WriteLine();

            // =======================
            // Task 5 - Enum & Record
            // =======================
            Console.WriteLine("=== Task 5: Enum and Record ===");

            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();

            DayType dayType;

            if (day == "friday" || day == "saturday")
            {
                dayType = DayType.Weekend;
            }
            else
            {
                dayType = DayType.Weekday;
            }

            Console.WriteLine("It is: " + dayType);
            Console.WriteLine();

            Book b1 = new Book("C# Basics", "Lord Ace", 29.99);
            Book b2 = b1 with { Title = "Advanced C#", Price = 39.99 };

            Console.WriteLine("Book 1: " + b1);

            var (title, author, price) = b2;
            Console.WriteLine("Book 2 Details:");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
            Console.WriteLine();

            // =======================
            // Task 6 - Debugging
            // =======================
            PercentageCalculator pc = new PercentageCalculator();
            pc.RunPercentageProgram();

            Console.WriteLine("Program finished.");
        }
    }
}
