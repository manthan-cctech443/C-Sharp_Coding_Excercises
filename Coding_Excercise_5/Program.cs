﻿using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintDay()
        {
            int day = 3;

            // TODO: Rewrite this if-else structure using a switch statement.
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Another day");
                    break;
            }
        }

        public static void Main(string[] args)
        {
            PrintDay();
        }
    }
}