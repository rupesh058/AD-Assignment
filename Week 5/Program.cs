using System;
using static System.Formats.Asn1.AsnWriter;

namespace Week_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("============Task 1============ ");

            // creating bank account object with account number and balance
            BankAccount myAccount = new BankAccount("ACC12345", 500);

            // printing account details
            Console.WriteLine("Account Number: " + myAccount.AccountNumber);
            Console.WriteLine("Initial Balance: " + myAccount.Balance);

            // depositing money
            myAccount.Deposit(500);

            // withdrawing money
            myAccount.Withdraw(800);

            // showing remaining balance
            Console.WriteLine("Remaining Balance: " + myAccount.Balance);

            Console.WriteLine("Thank you and Visit Again!");

            
            Console.WriteLine("============Task 2============ ");

            // creating car object
            Car myCar = new Car();
            myCar.Brand = "Toyota"; // setting car brand
            myCar.Speed = 150;      // setting speed
            myCar.Seats = 5;        // setting seats

            Console.WriteLine("=== Car Details ===");
            myCar.Start();          // calling start method
            myCar.DisplayInfo();    // displaying info
            myCar.Stop();           // stopping the car

            // creating motorcycle object
            MotorCycle myBike = new MotorCycle();
            myBike.Brand = "Yamaha";
            myBike.Speed = 90;
            myBike.HasCarrier = true;

            Console.WriteLine("=== Motorcycle Details ===");
            myBike.Start();
            myBike.DisplayInfo();
            myBike.Stop();

            
            Console.WriteLine("==========Task 3==========");

            Printer p = new Printer(); // creating printer object

            // Calling Print(string)
            p.Print("Hello My Lord");

            // Calling Print(int)
            p.Print(123);

            // Calling Print(string, int)
            p.Print("This is repeated message", 3);

            
            Console.WriteLine("==========Task 4==========");

            // creating NepaliTeacher object
            NepaliTeacher nt = new NepaliTeacher();
            nt.Name = "Preety ma'am"; // setting name

            Console.WriteLine("=== Nepali Teacher ===");
            Console.WriteLine("Name: " + nt.Name);
            nt.Teaching();     // overridden teaching method
            nt.SalaryInfo();   // sealed method from base

            Console.WriteLine();

            // creating EnglishTeacher object
            EnglishTeacher et = new EnglishTeacher();
            et.Name = "Anmol sir";

            Console.WriteLine("=== English Teacher ===");
            Console.WriteLine("Name: " + et.Name);
            et.Teaching();     // using base class teaching
            et.SalaryInfo();

            
            Console.WriteLine("==========Task 5==========");

            CarVehicle car = new CarVehicle(); // creating car vehicle
            Bike bike = new Bike();            // creating bike vehicle

            // calling methods for car
            car.Display();
            car.StartEngine();
            car.StopEngine();

            Console.WriteLine();

            // calling methods for bike
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();

            
            Console.WriteLine("==========Task 6==========");

            // Creating laptop object
            Laptop laptop = new Laptop("Dell", 1200.50);
            laptop.ShowInfo();  // showing laptop info

            // Creating smartphone object
            Smartphone phone = new Smartphone("Samsung", 850.75);
            phone.ShowInfo();   // showing smartphone info

            
            Console.WriteLine("==========Task 7==========");

            // Creating Laptop object for second class
            Laptop2 laptop2 = new Laptop2("HP", 1500);
            laptop2.ShowInfo();
            laptop2.TurnOnBattery(); // calling extra method

            Console.WriteLine();

            // Creating Smartphone object for second class
            Smartphone2 phone2 = new Smartphone2("iPhone", 999);
            phone2.ShowInfo();
            phone2.EnableCamera(); // calling extra method

            
            Console.WriteLine("==========Task 8==========");

            ElectronicsStore store = new ElectronicsStore(); // creating store

            // creating more objects
            Laptop laptop1 = new Laptop("Dell", 1500);
            Smartphone phone1 = new Smartphone("iPhone", 1200);

            // adding devices to store
            store.AddDevice(laptop);
            store.AddDevice(phone);

            // showing all device details
            store.ShowAllDeviceDetails();

            // removing laptop from store
            store.RemoveDevice(laptop);

            // showing again to confirm remove
            store.ShowAllDeviceDetails();

            Console.WriteLine("==========End of Program==========");
        }
    }
}
