using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.ThirdMax
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -5, -3, 0, 3, 5 };
            var result = ThirdMax(nums);

            Console.ReadLine();
        }

        static int ThirdMax(int[] nums)
        {
            long max = nums[0], max2nd = long.MinValue, max3rd = long.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max3rd = max2nd;
                    max2nd = max;
                    max = nums[i];
                }
                else if (nums[i] > max2nd)
                {
                    if (nums[i] != max)
                    {
                        max3rd = max2nd;
                        max2nd = nums[i];
                    }
                }
                else if (nums[i] > max3rd)
                    if (nums[i] != max2nd)
                        max3rd = nums[i];
            }
            return (int)(max3rd != long.MinValue ? max3rd : max);
        }
    }
}
