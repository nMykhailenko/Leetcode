using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeResolves.FourDivisors
{
    class Program
    {
        private static readonly int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313 };
        private static readonly Dictionary<int, bool> isPrime = primes.ToDictionary(p => p, p => true);
        private static readonly Dictionary<int, int> memo = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            var nums = new int[] { 7, 21, 105 };
            var result = SumFourDivisors(nums);

            Console.ReadLine();
        }

        static int SumFourDivisors(int[] nums)
        {
            return nums.Sum(FourDivisors);
        }

        private static int FourDivisorsImpl(int num)
        {
            foreach (var prime in primes)
            {
                var square = prime * prime;
                if (square >= num) break;
                if (num % prime == 0)
                {
                    var otherDivisor = num / prime;
                    return (otherDivisor == square || IsPrime(otherDivisor))
                        ? 1 + prime + otherDivisor + num
                        : 0;
                }
            }
            return 0;
        }

        private static bool IsPrimeImpl(int num)
        {
            foreach (var prime in primes)
            {
                var square = prime * prime;
                if (square > num) break;
                if (square == num || num % prime == 0)
                    return false;
            }
            return true;
        }

        private static int FourDivisors(int num)
        {
            if (memo.ContainsKey(num)) return memo[num];
            var answer = FourDivisorsImpl(num);
            memo[num] = answer;
            return answer;
        }

        private static bool IsPrime(int num)
        {
            if (isPrime.ContainsKey(num)) return isPrime[num];
            var answer = IsPrimeImpl(num);
            isPrime[num] = answer;
            return answer;
        }
    }

}
