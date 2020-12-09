using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.MaxArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new int[] { 1, 8, 3, 4, 8, 5, 7 };
            var result = MaxArea(n);
            Console.ReadKey();
        }
        
        static int MaxArea(int[] height)
        {
            int maxarea = 0, l = 0, r = height.Length - 1;
            while (l < r)
            {
                maxarea = Math.Max(maxarea, Math.Min(height[l], height[r]) * (r - l));
                if (height[l] < height[r])
                    l++;
                else
                    r--;
            }

            return maxarea;
        }
    }
}
