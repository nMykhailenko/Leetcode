using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.JumpGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2,3,1,1,4};
            var result = Jump(nums);
            Console.WriteLine($"Expected: 2, Actual: {result}");
            Console.ReadLine();
        }

        static int Jump(int[] nums)
        {
            var steps = 0;

            var currEnd = 0;
            var currFar = 0;

            for(var i = 0; i < nums.Length - 1; i++) {
                currFar = Math.Max(currFar, i + nums[i]);

                if(i == currEnd){
                    steps++;
                    currEnd = currFar;
                }
            }

            return steps;
        }
    }
}
