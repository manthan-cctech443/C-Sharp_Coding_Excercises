using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of Person with name "John" and age 30
            Person person = new Person("John", 30);

            // Call the Greet method
            person.Greet();
        }
    }

    public class Person
    {
        // Private member variable for name
        private string _name;

        // Public property for name with getter and setter
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Private member variable for age
        private int _age;

        // Public property for age with getter and custom setter
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        // Constructor to initialize name and age
        public Person(string name, int age)
        {
            _name = name;
            Age = age; // Use the property setter for validation
        }

        // Method to print a greeting message
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }
}
