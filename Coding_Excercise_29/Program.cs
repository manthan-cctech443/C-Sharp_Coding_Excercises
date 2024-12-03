using System;

namespace Coding.Exercise
{
    internal class Exercise
    {
        public static void NotHungryCats(string kitchen)
        {
            int pos = kitchen.IndexOf("F");
            string dir1 = kitchen.Substring(0, pos);
            string dir2 = kitchen.Substring(pos + 1);
            int count = 0;
            for (int i = 0; i < dir1.Length; i = i + 2)
            {
                if (dir1[i] == 'O')
                {
                    count++;
                }
            }
            for (int i = 0; i < dir2.Length; i = i + 2)
            {
                if (dir2[i] == '~')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        public static void Main(string[] args)
        {
            NotHungryCats("O~~O~O~OFO~O~");
        }
    }
}