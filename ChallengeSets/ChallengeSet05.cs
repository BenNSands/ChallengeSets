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
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var ans = "";
            if (words == null || words.Length == 0)
            {
                return "";
            }
            foreach (var word in words)
            {
                string trimStr = String.Concat(word.Where(c => !Char.IsWhiteSpace(c)));
                if (trimStr != "")
                {
                    ans += trimStr + " ";
                }
            }
            if (ans == "")
            {
                return ans;
            }
            return ans.Trim() + '.';

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var ifNull = new double[] { };
            if (elements == null)
            {
                return ifNull;
            }
            var ans = new List<double>();
            foreach (var num in elements)
            {
                if (num % 4 == 0)
                {
                    ans.Add(num);
                }
            }
           var arr =  ans.ToArray();
            return arr;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            var ans = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                var num1 = nums[i];
                for (int j = i+1; j < nums.Length; j++)
                {
                    var num2 = nums[j];

                    if (num1 + num2 == targetNumber)
                    {
                        ans = true;
                    }
                }
            }
            return ans;
        }
    }
}
