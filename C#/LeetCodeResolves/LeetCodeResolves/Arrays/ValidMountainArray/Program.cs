using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.ValidMountainArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 0, 3, 2, 1 };
            var result = ValidMountainArray(nums);

            Console.ReadLine();
        }

        static bool ValidMountainArray(int[] arr)
        {
            var n = arr.Length;
            var i = 0;

            while (i + 1 < n && arr[i] < arr[i + 1])
                i++;

            if (i == 0 || i == n - 1)
                return false;

            while (i + 1 < n && arr[i] > arr[i + 1])
                i++;

            return i == n - 1;
        }
    }
}
