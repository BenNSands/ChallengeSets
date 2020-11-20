using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var ans = 0;
            foreach (var num in numbers)
            {
                if (num % 2 ==0)
                {
                    ans += num;

                }
                else
                {
                    ans -= num;
                }
            }
            return ans;
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var arrOfStr = new string[] { str1, str2, str3, str4 };

            var shortestStr = arrOfStr.OrderBy(str => str.Length).FirstOrDefault();
            return shortestStr.Length;
            

            //throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arrOfNum = new int[] { number1, number2, number3, number4 };
            int ans = arrOfNum.Min();
            return ans;
            throw new NotImplementedException();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
