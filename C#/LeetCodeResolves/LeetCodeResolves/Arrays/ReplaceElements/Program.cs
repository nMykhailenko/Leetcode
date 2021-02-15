using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.ReplaceElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 3, 2, 1 };
            var result = ReplaceElements(nums);

            Console.ReadLine();
        }

        static int[] ReplaceElements(int[] arr)
        {
            if (arr.Length == 1) return new int[] { -1 };
            for(var i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1) 
                { 
                    arr[i] = -1; 
                }
                else
                {
                    var maxValue = FindMax(arr, i + 1);
                    arr[i] = maxValue;
                }
            }

            return arr;
        }

        static int FindMax(int[] arr, int startPosition)
        {
            var maxValue = 0;
            for(var i = startPosition; i < arr.Length; i++)
            {
                maxValue = Math.Max(arr[i], maxValue);
            }

            return maxValue;
        }
    }
}
