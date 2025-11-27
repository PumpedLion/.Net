using System;

namespace Workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1 Encapsulation
            Console.WriteLine("Task 1: Encapsulation & Properties");
            BankAccount acc = new BankAccount("ACC003", 6000);
            Console.WriteLine("Account Number: " + acc.AccountNumber);
            acc.Deposit(1500);
            acc.Withdraw(500);
            Console.WriteLine("Remaining Balance: " + acc.Balance);


            // TASK 2 Inheritance
            Console.WriteLine("\nTask 2: Inheritance");
            Car car = new Car { Brand = "Toyota", Speed = 120, Seats = 5 };
            Motorcycle mc = new Motorcycle { Brand = "Honda", Speed = 90, HasCarrier = true };
            car.Start();
            car.DisplayInfo();
            mc.Start();
            mc.DisplayInfo();


            // TASK 3 First Polymorphism
            Console.WriteLine("\nTask 3 First: Method Overloading");
            Printer p = new Printer();
            p.Print("Hello");
            p.Print(10);
            p.Print("Repeat", 3);


            // TASK 3 Second Polymorphism
            Console.WriteLine("\nTask 3 Second: Method Overriding");
            NepaliTeacher nt = new NepaliTeacher();
            EnglishTeacher et = new EnglishTeacher();
            nt.Teaching();
            nt.SalaryInfo();
            et.Teaching();
            et.SalaryInfo();


            // TASK 4 Abstraction
            Console.WriteLine("\nTask 4: Abstraction");
            AbsCar ac = new AbsCar();
            AbsBike ab = new AbsBike();
            ac.Display();
            ac.StartEngine();
            ab.Display();
            ab.StartEngine();


            // TASK 5 OOP
            Console.WriteLine("\nTask 5: OOP Concepts");
            ElectronicsStore store = new ElectronicsStore();
            store.AddDevice(new Laptop("Dell", 50000));
            store.AddDevice(new Smartphone("Samsung", 80000));
            store.ShowAllDeviceDetails();
        }
    }
}