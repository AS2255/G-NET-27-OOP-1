using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01_OOP
{
    class Student
    {
        public string Name;      // Accessible everywhere
        private int Age;         // Accessible only inside Student class

        public void SetAge(int age)
        {
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
