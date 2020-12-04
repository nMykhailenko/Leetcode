using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -3, 4, 3, 90};
            var target = 0;
            var result = TwoSum(nums, target);

            Console.WriteLine($"The result is: {result[0]}, {result[1]}.");
            Console.ReadLine();
        }

        static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for(var i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (dictionary.ContainsKey(complement))
                {
                    return new int[] { i, dictionary[complement] };
                }

                dictionary.Add(nums[i], i);
            }

            throw new InvalidOperationException();
        }
    }
}
