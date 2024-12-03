using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintRowSums()
        {
            // TODO
            int[,] arr2d = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum = sum + arr2d[i, j];
                }
                Console.WriteLine(sum);
            }

        }

        public static void Main(string[] args)
        {
            PrintRowSums();
        }
    }
}