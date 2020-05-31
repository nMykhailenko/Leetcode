using System;
using System.Collections.Generic;

namespace LeetCodeResolves.LongestSubstringWithoutRepeating
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = "dvdf";
            var s2 = " ";
            var s3 = "abcvvvcasd";

            var result1 = LengthOfLongestSubstring(s1);
            Console.WriteLine(result1);

            Console.ReadKey();
        }

        private static int LengthOfLongestSubstring(string s)
        {
            var res = 0;
            var start = 0;
            var dictionary = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dictionary[s[i]] + 1);
                    dictionary[s[i]] = i;
                }
                else
                {
                    dictionary.Add(s[i], i);
                }

                res = Math.Max(res, i - start + 1);
            }

            return res;
        }
    }
}
