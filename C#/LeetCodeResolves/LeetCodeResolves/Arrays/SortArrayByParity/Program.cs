using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.SortByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 3, 1, 2, 4 };
            var result = SortArrayByParity(arr);

            Console.ReadLine();
        }

        static int[] SortArrayByParity(int[] arr)
        {
            var slow = 0;
            var fast = 0;
            while (fast < arr.Length)
            {
                if (arr[slow] % 2 != 0)
                {
                    while (fast < arr.Length && arr[fast] % 2 != 0)
                    {
                        fast++;
                    }

                    if (fast == arr.Length)
                    {
                        return arr;
                    }
                    else
                    {
                        var temp = arr[slow];
                        arr[slow] = arr[fast];
                        arr[fast] = temp;
                    }
                }

                slow++;
                fast++;
            }

            return arr;
        }
    }
}
