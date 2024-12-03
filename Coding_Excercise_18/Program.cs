using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public void HandleMultipleExceptions(string input, int index)
        {
            int[] numbers = { 1, 2, 3 };

            try
            {
                int parsedNumber = int.Parse(input);

                Console.WriteLine(numbers[index]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }

        public static void Main(string[] args)
        {
            Exercise exercise = new Exercise();

            // Test with different inputs
            exercise.HandleMultipleExceptions("2", 1);
            exercise.HandleMultipleExceptions("abc", 1);
            exercise.HandleMultipleExceptions("2", 5);
        }
    }
}
