using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void SumOfTwo(int[] nums, int SumToFind)
        {
            // todo
            HashSet<int> seenNumbers = new HashSet<int>();
            HashSet<Tuple<int, int>> uniquePairs = new HashSet<Tuple<int, int>>();
            int count = 0;
            foreach (int num in nums)
            {
                int complement = SumToFind - num;
                if (seenNumbers.Contains(complement))
                {
                    Tuple<int, int> pair = complement < num ? Tuple.Create(complement, num) : Tuple.Create(num, complement);
                    if (!uniquePairs.Contains(pair))
                    {
                        uniquePairs.Add(pair);
                        count++;
                    }
                }
                seenNumbers.Add(num);
            }
            Console.WriteLine(count);
        }
        public static void Main(string[] args)
        {
            SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2);
        }
    }
}