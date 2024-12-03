using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void CheckAny()
        {
            // The list has been declared for you, use it in your solution.
            List<int> myNumbers = new List<int> { 1, 6, 3 };
            bool res = myNumbers.AsQueryable().Any(val => val > 5);
            Console.WriteLine(res);

            // TODO: Check if any number is greater than 5 using the Any method
            // and print the result ("True" or "False") to the console.
        }

        public static void Main(string[] args)
        {
            CheckAny();
        }
    }
}