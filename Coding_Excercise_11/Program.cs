using System;

namespace Coding.Exercise
{
    public class MyClass
    {
        // Declare a private readonly field to store the value
        private readonly string _value;

        // Create a public read-only property to expose the field's value
        public string Value
        {
            get { return _value; }
        }

        // Constructor to initialize the readonly field with the value parameter
        public MyClass(string value)
        {
            _value = value;
        }
    }

    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            // Create an instance of MyClass with the value "Read-Only Property Value"
            MyClass myObject = new MyClass("Read-Only Property Value");

            // Print the value of the read-only property to the console
            Console.WriteLine(myObject.Value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintReadOnlyProperty();
        }
    }
}