using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.MaxConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1 };
            var result = FindMaxConsecutiveOnes(nums);

            Console.ReadLine();
        }

        static int FindMaxConsecutiveOnes(int[] nums)
        {
            var maxLength = 0;
            var currLength = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    currLength++;
                }
                else
                {
                    maxLength = Math.Max(currLength, maxLength);
                    currLength = 0;
                }
            }

            return Math.Max(currLength, maxLength);
        }
    }
}
