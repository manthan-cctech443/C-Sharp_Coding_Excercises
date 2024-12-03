using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static int DoubleValue(int number)
        {
            // TODO: Implement the method to double the value
            number = number * 2;
            return number;
        }

        public static void Main(string[] args)
        {
            // TODO: Call DoubleValue and print the result
            int num = DoubleValue(10);
            Console.WriteLine(num);
        }
    }
}