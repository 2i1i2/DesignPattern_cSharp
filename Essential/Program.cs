using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Essential features
             * Classes
             * Interfaces
             * Encapsulation
             * Abstraction
             * Inheritance
             * Polymorphism
             * UML
             */

            // Instance 
            User user = new User();

            User user1 = new User(name: "Nitin Kumar Gautam"); // parametrized constructor

            user.Name = "Nitin";

            // calling method
            user.sayHelllo();

            Console.WriteLine(user.Name);


            Console.WriteLine($"{user1}");

            Console.ReadKey();
        }
    }
}
