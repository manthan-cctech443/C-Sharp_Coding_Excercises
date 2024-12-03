using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintNumbers()
        {
            // TODO
            List<int> numbers = new List<int> { 1, 2, 3 };
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
        }

        public static void Main(string[] args)
        {
            PrintNumbers();
        }
    }
}