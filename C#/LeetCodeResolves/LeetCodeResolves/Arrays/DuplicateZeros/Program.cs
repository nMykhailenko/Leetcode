using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.DuplicateZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -5, -3, 0, 3, 5 };
            DuplicateZeros(nums);

            Console.ReadLine();
        }

        static void DuplicateZeros(int[] arr)
        {
            var possibleDups = 0;
            var length = arr.Length - 1;

            for (var left = 0; left <= length - possibleDups; left++)
            {
                if (arr[left] == 0)
                {
                    if (left == length - possibleDups)
                    {
                        arr[length] = 0;
                        length -= 1;
                        break;
                    }
                    possibleDups++;
                }
            }

            var last = length - possibleDups;
            for (var i = last; i >= 0; i--)
            {
                if (arr[i] == 0)
                {
                    arr[i + possibleDups] = 0;
                    possibleDups--;
                    arr[i + possibleDups] = 0;
                }
                else
                {
                    arr[i + possibleDups] = arr[i];
                }
            }
        }
    }
}
