using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.StringToInt_ATOI
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "+1";
            var result = MyAtoi(input);
            Console.ReadLine();
        }
        
        static int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int i = 0;
            int ret = 0;
            int n = s.Length;
            bool isNeg = false;

            var set = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            while (i < n && s[i] == ' ')
            {
                i += 1;
            }

            if (i < n && s[i] == '-')
            {
                isNeg = true;
                i += 1;
            }
            else if (i < n && s[i] == '+')
            {
                isNeg = false;
                i += 1;
            }


            while (i < n)
            {
                if (!set.Contains(s[i]) && ret > 0)
                {
                    return isNeg ? -ret : ret;
                }

                if (!set.Contains(s[i]))
                {
                    return 0;
                }

                int num = s[i] - '0';
                if (ret > int.MaxValue / 10 || ret == int.MaxValue / 10 && num >= 8)
                {
                    return isNeg ? int.MinValue : int.MaxValue;
                }

                ret *= 10;
                ret += num;
                i += 1;
            }

            return isNeg ? -ret : ret;
        }
    }
}
