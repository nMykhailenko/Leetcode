using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.SortedSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -5, -3, 0, 3, 5 };
            var result = SortedSquares(nums);

            Console.ReadLine();
        }

        static int[] SortedSquares(int[] nums)
        {
            var result = new int [nums.Length];
            var left = 0;
            var right = nums.Length - 1;
            for(var i = nums.Length - 1; i >= 0; i--)
            {
                if(Math.Abs(nums[right]) > Math.Abs(nums[left]))
                {
                    result[i] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    result[i] = nums[left] * nums[left];
                    left++;
                }
            }

            return result;
        }
    }
}
