using System;

namespace Week3Workshop
{
    public class NullOperations
    {
        public void PerformNullChecks()
        {
            Console.WriteLine("Enter your Name: "); 
            // username is null
            string? username = Console.ReadLine();


            // Ternary check
            Console.WriteLine(username == null ? "Username is not available" : username);

            // Null coalescing ??
            Console.WriteLine(username ?? "Username is not available");

            // Null coalescing assignment ??=
            username ??= "guest_user";

            Console.WriteLine("After ??= : " + username);
        }
    }
}