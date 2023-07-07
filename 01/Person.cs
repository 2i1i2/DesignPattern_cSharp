using System;
namespace _01
{
    public class Person
    {
        public string PersonName { get; set; }

        public Person() { }

        public Person(string name)
        {
            PersonName = name;
        }
        // method
        public void PersonNameMethod()
        {
            Console.WriteLine($"Person name is: {PersonName}");
        }
    }
}
