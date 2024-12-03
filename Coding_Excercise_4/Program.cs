using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void CheckLogin()
        {
            bool isLoggedIn = true;

            // Assign a value to isLoggedIn based on user input or condition

            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }
        }

        public static void Main(string[] args)
        {
            CheckLogin();
        }
    }
}