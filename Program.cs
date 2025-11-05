// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Circle
{
    public const double PI = 3.14;
}

class Program
{
    static void Main(string[] args)
    {
        // Task 1
        string userName = "Dev Kumar Rai";
        int luckyNumber = 5;
        Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

        // Task 2
        double radius = 5;
        double area = Circle.PI * radius * radius;
        double perimeter = 2 * Circle.PI * radius;
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);

        // Task 3
        byte b = 10;
        short s = 1000;
        int i = 50000;
        long l = 10000000000;
        float f = 3.14f;
        double d = 3.14159;
        decimal dec = 10.123456m;
        char ch = 'A';
        bool flag = true;

        string intToString = i.ToString();
        double stringToDouble = Convert.ToDouble("3.14");

        Console.WriteLine("Byte: " + b);
        Console.WriteLine("Short: " + s);
        Console.WriteLine("Int: " + i);
        Console.WriteLine("Long: " + l);
        Console.WriteLine("Float: " + f);
        Console.WriteLine("Double: " + d);
        Console.WriteLine("Decimal: " + dec);
        Console.WriteLine("Char: " + ch);
        Console.WriteLine("Bool: " + flag);
        Console.WriteLine("Converted int to string: " + intToString);
        Console.WriteLine("Converted string to double: " + stringToDouble);

        // Task 4
        int[] favNumbers = { 5, 9, 2, 7, 1 };
        Array.Sort(favNumbers);
        Array.Reverse(favNumbers);

        Console.WriteLine("Array elements:");
        for (int x = 0; x < favNumbers.Length; x++)
        {
            Console.WriteLine(favNumbers[x]);
        }

        int index = Array.IndexOf(favNumbers, 7);
        Console.WriteLine("Index of 7 is: " + index);

        // Task 5
        DateTime birthDate = new DateTime(2004, 1, 1);
        DateTime now = DateTime.Now;
        TimeSpan ageSpan = now - birthDate;
        int age = (int)(ageSpan.Days / 365);

        Console.WriteLine("Birthdate: " + birthDate);
        Console.WriteLine("Current Date: " + now);
        Console.WriteLine("Age: " + age);

        DateTime plusTenDays = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + plusTenDays);

        // Task 6
        List<string> fruits = new List<string>() { "Mango", "Apple", "Banana" };
        fruits.Add("Orange");
        fruits.Remove("Apple");

        Console.WriteLine("Fruits List:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDict = new Dictionary<int, string>();
        fruitDict.Add(1, "Banana");
        fruitDict.Add(2, "Grapes");
        fruitDict.Add(3, "Orange");
        fruitDict.Add(4, "Mango");

        Console.WriteLine("Fruit Dictionary:");
        foreach (var item in fruitDict)
        {
            Console.WriteLine("Key: " + item.Key + ", Value: " + item.Value);
        }
    }
}