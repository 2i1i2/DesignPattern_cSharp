using System;

namespace Essential
{
    public class User
    {
        // fields
        public string Name;

        
        // getter and setter can use 3 types
        // 1.

         public  string _name { get; set; }


        // 2nd
        public string address;
        public string myAddress
        {
            get { return address; }
            set { address = value; }
        }

        // 3rd
        //getter 
        public string getName()
        {
            return this.Name;
        }
        // setter
        public void setName(string value)
        {
            this.Name = value;
        }

        // empty constructor
        public User()
        {

        }

        // paramatrized constructor
        public User(string name)
        {
            this.Name = name;
        }


        // method
        public void sayHelllo()
        {
            Console.WriteLine($"Hi my name is {Name}");
        }

    }
}
