using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            throw new NotImplementedException();
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
            
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
