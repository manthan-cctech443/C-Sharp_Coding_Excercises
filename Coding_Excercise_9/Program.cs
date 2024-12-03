using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintAverage(double[] temperatures)
        {
            // TODO
            double avgtemp = CalculateAverage(temperatures);
            Console.WriteLine("The average temperature is: " + (avgtemp));
        }

        public static double CalculateAverage(double[] temperatures)
        {
            // TODO
            double sum = 0.0;
            foreach (double i in temperatures)
            {
                sum = sum + i;
            }
            return sum / temperatures.Length;
        }

        public static void Main(string[] args)
        {
            double[] temperatures = {2,4,5,6};
            PrintAverage(temperatures);
        }
    }
}