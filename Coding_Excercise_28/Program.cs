using System;
using System.Text.RegularExpressions;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void ExtractPatterns(string input)
        {
            // TODO: Implement the method to extract and print email addresses using regex
            string emailPattern = @"[a-zA-Z]+@[a-z]+\.[a-z]{3,}";

            Regex regex = new Regex(emailPattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        public static void Main(string[] args)
        {
            ExtractPatterns("Contact us at support@example.com or sales@example.org.");
        }
    }
}