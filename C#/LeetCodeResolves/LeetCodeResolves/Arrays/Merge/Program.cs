using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.Arrays.Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 6, 10, 0, 0 };
            var nums2 = new int[] { 2, 11 };
            var m = 3;
            var n = 2;
            Merge(nums1, m, nums2, n);

            Console.ReadLine();
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var len = n + m;
            var i = m - 1;
            var j = n - 1;
            var k = 1;

            while(i >=0 || j >= 0)
            {
                if(i >= 0 && j >= 0)
                {
                    if(nums1[i] < nums2[j])
                    {
                        nums1[len - k] = nums2[j--];
                    }
                    else
                    {
                        nums1[len - k] = nums1[i--];
                    }

                    k++;
                    continue;
                }

                if (i >= 0)
                {
                    nums1[len - k] = nums1[i--];
                    k++;
                }

                if (j >= 0)
                {
                    nums1[len - k] = nums2[j--];
                    k++;
                }
            }
        }
    }
}
