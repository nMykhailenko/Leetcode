using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.FindNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1 };
            var result = FindNumbers(nums);

            Console.ReadLine();
        }

        static int FindNumbers(int[] nums)
        {
            var count = 0;
            for(var i = 0; i < nums.Length; i++)
            {
                var digitCount = 0;
                var value = nums[i];
                while(value > 0)
                {
                    value = value / 10;
                    digitCount++;
                }

                if (digitCount % 2 == 0)
                    count++;
            }

            return count;
        }
    }
}
