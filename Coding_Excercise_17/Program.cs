using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintWithFinally()
        {
            // TODO
            try
            {
                Console.WriteLine("Trying...");
            }
            finally
            {
                Console.WriteLine("Finally executed.");
            }

        }

        public static void Main(string[] args)
        {
            PrintWithFinally();
        }
    }
}