using System;
using System.Collections.Generic;

namespace LeetCodeResolves.ContainsDuplicate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {2, 5, 1, 1, 4, 7};
            var result = ContainsDuplicate(nums);
            Console.ReadLine();
        }
        
        static bool ContainsDuplicate(int[] nums) {
            var dictionary = new Dictionary<int, int>();

            foreach(var num in nums){
                if(dictionary.ContainsKey(num)){
                    return true;
                }
        
                dictionary.Add(num, 0);
            }

            return false;
        }    
    }
}