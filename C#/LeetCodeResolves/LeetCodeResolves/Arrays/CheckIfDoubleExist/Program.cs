using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.CheckIfDoubleExist
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -2, 0, 10, -19, 4, 6, -8 };
            var result = CheckIfExist(nums);

            Console.ReadLine();
        }

        static bool CheckIfExist(int[] arr)
        {
            for(var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    var div = arr[i] / 2d;
                    var mul = arr[i] * 2;
                    if (mul == arr[j] || div == arr[j])
                        return true;
                }
            }

            return false;
        }
    }
}
