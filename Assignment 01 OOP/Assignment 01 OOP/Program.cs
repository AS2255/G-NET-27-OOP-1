using CinemaLibrary;
using CinemaLibrary.Enum;
using System.Security.AccessControl;

namespace Assignment_01_OOP
{
    // Class (Reference Type)
    class PersonClass
    {
        public string Name;
    }

    // Struct (Value Type)
    struct PersonStruct
    {
        public string Name;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Question 1
            /*
                Explain with code example how class and struct behave differently 

                Feature              Struct                                     Class
                Type                 Value type                                 Reference type
                Stored In            Stack                                      Heap (reference on stack)
                Assignment           Copies the data                            Copies the reference
                Inheritance          Not supported                              Supported
                Null                 Cannot be null (unless nullable)           Can be null
             */

            #region Example
            //// CLASS behavior
            //PersonClass p1 = new PersonClass();
            //p1.Name = "Ahmed";

            //PersonClass p2 = p1; // copies reference
            //p2.Name = "Ali";

            //Console.WriteLine("Class Example:");
            //Console.WriteLine(p1.Name); // Ali
            //Console.WriteLine(p2.Name); // Ali

            //Console.WriteLine();
            ////Class result: Ali Ali ==> Because both variables point to the same object.

            //// STRUCT behavior
            //PersonStruct s1 = new PersonStruct();
            //s1.Name = "Ahmed";

            //PersonStruct s2 = s1; // copies value
            //s2.Name = "Ali";

            //Console.WriteLine("Struct Example:");
            //Console.WriteLine(s1.Name); // Ahmed
            //Console.WriteLine(s2.Name); // Ali 

            ////Struct result: Ahmed Ali ==> Because struct creates a copy.
            #endregion

            #endregion

            #region Question 2
            //Explain the difference between public and private access modifiers with an example

            //public
            //Accessibility: The member is accessible from anywhere in the application
            //Usage: Use when you want to expose a class or method to other code

            //private
            //Accessibility: The member is only accessible within the class or struct it is defined in
            //Usage: Use for members that should only be accessible within the class

            #region public VS private

            //Student s = new Student();

            //s.Name = "Ahmed";   // Allowed (public)
            ////s.Age = 20;      // ERROR (private)

            //s.SetAge(20);      // Correct way

            //s.Display();

            #endregion

            #endregion

            #region Question 3
            // Describe the steps to create and use a class library in Visual Studio
            /*
             Step 1: Create Class Library
                1.Open Visual Studio
                2.Click Create new project
                3.Select Class Library (.NET)
                4.Click Next
                5.Enter project name  And Click Create
            Step 2: Add class then Build the Project
            Step 3: Use the library in another project (Creat Console App)
            Step 4: Add reference
                    Right click Console App → References → Add Reference
            Step 5: Use the library
             */


            #endregion

            #region Question 4

            /*
             What is a class library? Why do we use class libraries?
                
            A Class Library is a separate project that contains a collection of 
                reusable classes, methods, and functions compiled into a DLL file
                it has no Main method and cannot run on its own
            Why we use class libraries
                1. Code reuse ==> Write once, use many times.
                2. Better organization ==> Separate concerns into different assemblies
                3. Easier maintenance ==> Fix code in one place, all projects benefit.
                4. Teamwork ==> different developers work on different libraries
             */

            #endregion

            #endregion

            #region P2 MovieBookingApp
            //Console.Write("Enter Movie Name: ");
            //string movieName = Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard , 1 = VIP , 2 = IMAX ): ");
            //TicketType type = (TicketType)int.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Row (A, B, C...): ");
            //char row = char.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Enter Price: ");
            //double price = double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discount = double.Parse(Console.ReadLine());

            //Seat seat = new Seat(row, number);

            //Ticket ticket = new Ticket(movieName, type, seat, price);

            //double tax = 14;

            //Console.WriteLine();
            //Console.WriteLine("===== Ticket Info =====");
            //ticket.PrintTicket(tax);

            //Console.WriteLine();
            //Console.WriteLine("===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discount:F2}");
            //ticket.ApplyDiscount(ref discount);

            //Console.WriteLine($"Discount After : {discount:F2}");
            //ticket.PrintTicket(tax);
            #endregion
        }
    }
}
