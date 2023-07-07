using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PersonName = "Sukhveer singh";

            Person person2 = new Person("John Sinha");
            
            // calling method
            person.PersonNameMethod();

            Console.WriteLine(person2.PersonName);
            Console.ReadKey();
        }
    }
}
