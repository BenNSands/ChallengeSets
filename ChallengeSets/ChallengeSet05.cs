using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            var ans = startNumber;
            do
            {
                ++ans;
            } while (ans % n != 0);
            return ans;
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
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var ans = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    ans += numbers[i];
                }
            }
            return ans;
            //throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {

            throw new NotImplementedException();
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
