using System;

namespace CSharpTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------- Task 1 ----------------

            Student student1 = new Student();
            Student student2 = new Student();

            // Assign instance fields
            student1.Name = "Dev";
            student1.Age = 22;
            student1.Email = "dev@example.com";

            student2.Name = "Nikhil";
            student2.Age = 21;
            student2.Email = "nikhil@example.com";

            // Display instance fields
            Console.WriteLine($"Student 1: {student1.Name}, {student1.Age}, {student1.Email}");
            Console.WriteLine($"Student 2: {student2.Name}, {student2.Age}, {student2.Email}");

            // Display static field
            Console.WriteLine($"College Name: {Student.CollegeName}");

            // ---------------- Task 2 ----------------
            Calculator calc = new Calculator();
            calc.PrintWelcome();

            int sum = calc.Add(10, 20);
            Console.WriteLine($"Addition of Number is : {sum}");

            int product1 = calc.Multiply(5, 4);
            int product2 = calc.Multiply(6); // uses default value
            Console.WriteLine($"Multiplication  of 1: {product1}");
            Console.WriteLine($"Multiplication of 2 (default param): {product2}");

            // ---------------- Task 3 ----------------
            ParameterDemo demo = new ParameterDemo();

            int number = 15;
            demo.Increase(ref number);
            Console.WriteLine($"After Increase (ref): {number}");

            demo.GetFullName(out string fullname);
            Console.WriteLine($"Full Name (out): {fullname}");

            int totalSum = demo.SumAll(1, 2, 3, 4, 5);
            Console.WriteLine($"Sum All parameters is : {totalSum}");

            // ---------------- Task 4 ----------------
            Player player1 = new Player(); // Default constructor
            Player player2 = new Player("Ronaldo", 5, 100); // Parameterized constructor

            // Display player2 fields
            Console.WriteLine($"Player 2: {player2.PlayerName}, {player2.Level}, {player2.Health}");

            // ---------------- Task 5 ----------------
            Console.Write("Enter a day: ");
            string inputDay = Console.ReadLine() ?? ""; // Handle possible null

            DayType dayType = (inputDay.ToLower() == "friday" || inputDay.ToLower() == "saturday") 
                ? DayType.Weekend 
                : DayType.Weekday;
            Console.WriteLine($"It is : {dayType}");

            Book book1 = new Book("Rich Dad Poor Dad", "Robert Robert Kiyosaki", 650);
            Book book2 = book1 with { title = "The Metamorphosis", price = 1000 };

            Console.WriteLine($"Book1: {book1}");
            var (title, author, price) = book2;
            Console.WriteLine($"Book2 Deconstructed: Title={title}, Author={author}, Price={price}");

            // ---------------- Task 6 ----------------
            Console.Write("Enter marks: ");
            string marksInput = Console.ReadLine() ?? "";
            Console.Write("Enter total: ");
            string totalInput = Console.ReadLine() ?? "";

            // TryParse to prevent errors
            bool isMarksValid = int.TryParse(marksInput, out int marks);
            bool isTotalValid = int.TryParse(totalInput, out int total);

            if (!isMarksValid || !isTotalValid || total == 0)
            {
                Console.WriteLine("Invalid input! Total cannot be zero and inputs must be integers.");
            }
            else
            {
                // Breakpoint 1: before calculation
                double percentage = (double)marks / total * 100; // Correct calculation
                // Breakpoint 2: after calculation
                Console.WriteLine($"Percentage: {percentage}%");
                
                /*
  My Observations:
1.	When I initially executed the program without any casting, the result turned out incorrect. For instance, 
with marks = 45 and total = 50, the output became 0 instead of 90. This occurred because both variables were integers, 
and integer division automatically cuts off the decimal portion.
2.	I resolved the issue by converting marks into a double: (double)marks / total * 100. After applying this cast, 
the program started producing the correct percentage.
3.	By placing breakpoints around the calculation, I was able to inspect the values of marks, total, and the computed 
percentage, which helped me clearly understand why the initial output was wrong.
4.	Implementing TryParse was also essential, as it prevented the program from crashing whenever the user entered 
something that wasn’t a valid number.
5.	Overall, this experience taught me the importance of paying attention to data types and properly handling 
invalid or unexpected user input during calculations.
  */
                /*
                 
                 
Task 7: Research Activity

Part 1: Constructors in Software Development
--------------------------------------------------
Special functions within a class are known as constructors which are automatically executed when an object is created. 
Their primary use is to initialize the object with sound initial values so that all begins in a similar state. 
Having the entire logic of the setups within the construction would help it become easier to maintain and would 
also reduce the chances of receiving errors due to un-initiated data. 
Beneficial Practical Scenarios of Constructors. 
1.	Banking System -Creation of an Account. 
In the creation of a new bank account object, the account number, details about the customer and the initial balance 
can be assigned immediately to the object. 
2.	E-Commerce Platform- Product Setup. 
A Product class is capable of defining a Product title, cost and available stock attributes through a Constructor 
that ensures that each product object is created with appropriate attributes. 
3.	Smart Home Technology - Device Startup. 
In the case of a smart thermostat or other gadgets, a builder will have the ability to program the device with the
basic requirements like default temperature, device name, and connection.

Resources:
  Microsoft : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors
  GeeksforGeeks: https://www.geeksforgeeks.org/c-sharp/constructors-c-sharp/


Part 2: OOP Principle - Encapsulation
--------------------------------------------------
Encapsulation can be defined as limiting the access to the internal behaviours of a class.A class offers controlled 
communication with the outside world in the form of public methods or properties, instead of direct exposure.
This secures the data of the object against accidentally introduced changes, as well as ensures the codebase remains 
more structured and reputable.

Classes and Objects explained.
A class is a structure which specifies attributes and actions.
An instance is a physical object developed out of that type, possessing its values.
Example:
A car type defines car features such as model and engine type and myCar is a car which is of a certain color or year.
Applications in Real Life of Encapsulation.
1. Banking Application
The balance field remains confidential and the Deposit and Withdraw methods are safe as they update the balance field.
2. Student Information System
The scores of the students are concealed in the classroom. Controlled access is through the public methods like 
GetGrade or UpdateGrade.

Resources:
  Microsoft : https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop
  GeeksforGeeks: https://www.geeksforgeeks.org/c-sharp/encapsulation-in-c-sharp/
*/

            }
        }
    }
}
