using System;

namespace Coding.Exercise
{
    public class Person
    {
        public Person(string name)
        {
            Console.WriteLine($"Person constructor: {name}");
        }
    }
    public class Employee : Person
    {
        public Employee(string name, int id) : base(name)
        {
            Console.WriteLine($"Employee constructor: {name}, ID: {id}");
        }
    }

    public class Exercise
    {
        public void PrintMessages()
        {
            Employee emp = new Employee("John Doe", 123);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            exercise.PrintMessages();
        }
    }
}


