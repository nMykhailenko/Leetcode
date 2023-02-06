using System;

namespace LeetCodeResolves.ShuffleTheArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {2, 5, 1, 3, 4, 7};
            var result = Shuffle(nums, 3);
            Console.ReadLine();
        }
        
        static int[] Shuffle(int[] nums, int n) {
            var half = (long)(nums.Length / 2);
            var result = new int[nums.Length];
           
            var current = 0;
            var pair = half;
            for(var i = 0; i < half; i++){
                result[current] = nums[i];
                result[current + 1] = nums[pair];
    
                current += 2;
                pair += 1;
            }

            return result;
        }
    }
}