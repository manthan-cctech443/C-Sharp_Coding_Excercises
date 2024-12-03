using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintNumbers()
        {
            // Initialize array and print each number using a foreach loop
            int[] arr1 = { 1, 2, 3, 4, 5 };
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            PrintNumbers();
        }
    }
}