using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeResolves.FruitInBaskets
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new int[] {3,3,3,1,2,1,1,2,3,3,4};
            var result = TotalFruit(fruits);

            Console.ReadLine();
        }

        static int TotalFruit(int[] fruits)
        {
            int left = 0, right = 0, cnt = 0, res = 0;
            var dic = new Dictionary<int,int>();
            while(right < fruits.Length)
            {
                if(dic.ContainsKey(fruits[right]))
                    dic[fruits[right]]++;
                else
                    dic.Add(fruits[right], 1);             
            
                if(dic[fruits[right]]== 1)
                    cnt++;
            
                right++;
            
                while(cnt > 2)
                {
                    dic[fruits[left]]--;
                    if(dic[fruits[left]] == 0)
                        cnt--;
                    left++;
                }
            
                res = Math.Max(res, right - left);
            }
            
            return res;
        }
    }
}
