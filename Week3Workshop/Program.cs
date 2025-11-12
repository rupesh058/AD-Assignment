namespace Week3Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects
            Operators op = new Operators();
            NullOperations nullOps = new NullOperations();
            AgeChecker age = new AgeChecker();
            DayOfWeekSwitch day = new DayOfWeekSwitch();
            LoopTasks loops = new LoopTasks();
            ExceptionTasks ex = new ExceptionTasks();

            Console.WriteLine("=== Task 1 ===");
            op.Add(10, 5);
            op.Subtract(10, 5);
            op.Multiply(10, 5);
            op.Divide(10, 2);
            op.OddEvenFinder(7);

            Console.WriteLine("\n=== Task 2 ===");
            nullOps.PerformNullChecks();

            Console.WriteLine("\n=== Task 3 ===");
            age.CheckAge();

            Console.WriteLine("\n=== Task 4 ===");
            day.PrintDay();

            Console.WriteLine("\n=== Task 5 ===");
            loops.SumToN();
            loops.WhileLoopPrint();
            loops.SumArray();

            Console.WriteLine("\n=== Task 6 ===");
            ex.ConvertNumber();
            ex.PasswordCheck();

        }
    }
}
