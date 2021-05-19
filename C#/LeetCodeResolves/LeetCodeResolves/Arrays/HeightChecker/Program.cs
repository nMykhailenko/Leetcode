using System;

namespace LeetCodeResolves.Arrays.HeightChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var heights = new int[] { 1, 1, 4, 2, 1, 3 };
            var result = HeightChecker(heights);

            Console.ReadLine();
        }

        static int HeightChecker(int[] heights)
        {
            var expected = new int[heights.Length];
            for(var i = 0; i < heights.Length; i++)
            {
                expected[i] = heights[i];
            }

            Array.Sort(expected);

            var count = 0;
            for(var i = 0; i< heights.Length; i++)
            {
                if(heights[i] != expected[i])
                {
                    count++;
                }
            }


            return count;
        }
    }
}
