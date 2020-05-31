using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeResolves.MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = new int[] { 1, 1 };
            var num2 = new int[] { 1, 2 };

            var res = FindMedianSortedArrays(num1, num2);

            Console.ReadLine();
        }

        private static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var mergedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(mergedArray);

            return GetMedian(mergedArray);
        }

        private static double GetMedian(int[] arr)
        {
            int idx = arr.Count() / 2;
            if (arr.Length % 2 == 0)
            {
                return (double)((double)(arr[idx] + arr[idx - 1]) / 2);
            }
            else
            {
                return arr[idx];
            }
        }
    }
}
