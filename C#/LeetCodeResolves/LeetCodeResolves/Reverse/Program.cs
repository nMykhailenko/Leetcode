using System;

namespace LeetCodeResolves.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Reverse(1534236469);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Reverse(int x)
        {
            try
            {
                var chars = Math.Abs(x).ToString().ToCharArray();
                Array.Reverse(chars);
                var resultAsStr = new string(chars);
                var result = x > 0 ? Convert.ToInt32(resultAsStr) : Convert.ToInt32($"-{resultAsStr}");
                return result;
            }
            catch(OverflowException ex)
            {
                return 0;
            }
        }
    }
}
