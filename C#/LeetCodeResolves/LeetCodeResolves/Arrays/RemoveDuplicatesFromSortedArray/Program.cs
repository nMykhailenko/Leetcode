using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            var result = RemoveDuplicates(nums);

            Console.ReadLine();
        }

        static int RemoveDuplicates(int[] nums)
        {
            var n = nums.Length;
            if (n == 0) return 0;

            var i = 0;
            for(var j = 1; j < n; j++)
            {
                if(nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}
