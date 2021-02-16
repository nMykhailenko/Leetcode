using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 0, 3, 2, 1 };
             MoveZeroes(arr);

            Console.ReadLine();
        }

        static void MoveZeroes(int[] arr)
        {
            var slow = 0;
            var fast = 0;
            while (fast < arr.Length)
            {
                if (arr[slow] == 0)
                {
                    while (fast < arr.Length && arr[fast] == 0)
                    {
                        fast++;
                    }

                    if (fast == arr.Length)
                    {
                        return;
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
        }
    }
}
