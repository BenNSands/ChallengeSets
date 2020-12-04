using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue <= 0)
                {
                    biz.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else if (numbers.Length == 0)
            {
                return false;
            }
            var ans = true;
            var check = numbers.OrderBy(num => num).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != check[i])
                {
                    ans = false;
                }
            }
            return ans;
            //throw new NotImplementedException();
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var ans = "";
            foreach (var word in words)
            {
                ans = ans + " " + word;
            }
            return ans;
            //throw new NotImplementedException();
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
