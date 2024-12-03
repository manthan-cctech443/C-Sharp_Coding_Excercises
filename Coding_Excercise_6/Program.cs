using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void SimpleCalculator()
        {
            // TODO: Implement the calculator logic here
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an operation: +, -, *, /");
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;

                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        break;
                    }
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            SimpleCalculator();
        }
    }
}