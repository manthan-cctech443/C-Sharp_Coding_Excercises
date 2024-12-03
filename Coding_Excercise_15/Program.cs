using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void PrintDictionaryValues()
        {
            // TODO
            Dictionary<string, List<int>> My_dict1 = new Dictionary<string, List<int>>();
            My_dict1.Add("a", new List<int> { 1, 2, 3 });
            foreach (var pair in My_dict1)
            {
                Console.Write($"{string.Join(" ", pair.Value)}");
            }
            Console.Write(" ");

        }

        public static void Main(string[] args)
        {
            PrintDictionaryValues();
        }
    }
}