using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var ans = false;

            if (words == null)
            {
                return false;
            }

            if (ignoreCase == true)
            {

                foreach (var item in words)
                {
                    if (item != null)
                    {
                        if (word.ToLower() == item.ToLower())
                        {
                            ans = true;
                        }
                    }
                   
                }
            }


            if (ignoreCase == false)
            {
                foreach (var item in words)
                {
                    if (word == item)
                    {
                        ans = true;
                    }
                }
            }
           
            return ans;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }

            var limit = Math.Ceiling(Math.Sqrt(num));

            for (int i = 2; i <= limit; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
                return true;
            

        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var counter = 0;
            var ans = 0;
            if (str.Length == 1)
            {
                return 0;
            }
            if (str == "")
            {
                return -1;
            }
            var count = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foreach (var lett in str)
                {
                    if (str[i] == lett)
                    {
                        count[i]++;
                    }
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] == 1)
                {
                    ans = i;
                }
                else if(count[i] > 1)
                {
                    counter++;
                }
            }
            if (counter == str.Length)
            {
                return -1;
            }
            return ans;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var ans = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                var curCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j])
                        break;
                        curCount++;
                    
                    
                }
                if (curCount > ans)
                {
                    ans = curCount;
                }
            }
            return ans;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var ifNull = new double[] { };
            if (elements == null || n < 0)
            {
                return ifNull;
            }

            var ans = new List<double>();

            foreach (var num in elements)
            {
                if (num % n == 0)
                {
                    ans.Add(num);
                }
            }
            var arr = ans.ToArray();
            return arr;
        }
    }
}
