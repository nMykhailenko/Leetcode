using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0 , 1 , 0, 1 , 2, 5, 6 };
            var result = RemoveElement(nums, 1);

            Console.ReadLine();
        }

        static int RemoveElement(int[] nums, int val)
        {
            var i = 0;
            var n = nums.Length;
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                }
                else
                {
                    i++;
                }
            }

            return n;
        }
    }
}
