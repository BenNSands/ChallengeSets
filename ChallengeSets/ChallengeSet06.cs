using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            var ans = false;

            var newList = new List<string>();

            if (ignoreCase == true)
            {
                word = word.ToLower();
                foreach (var item in words)
                {
                    newList.Add(item.ToLower());
                }

                foreach (var item in newList)
                {
                    if (word == item)
                    {
                        ans = true;
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
            if (num <= 0)
            {
                return false;
            }
            if (num == 1) 
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
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
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
