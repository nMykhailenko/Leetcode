using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 121;
            var result = IsPalindrome(n);
            Console.ReadKey();
        }

        static bool IsPalindrome(int x)
        {
            var n = x;
            var rev = 0;
            while (x > 0)
            {
                var dig = x % 10;
                rev = rev * 10 + dig;
                x /= 10;
            }

            return rev == n;
        }
    }
}
