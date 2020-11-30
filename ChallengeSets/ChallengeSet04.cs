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
          
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var arrOfStr = new string[] { str1, str2, str3, str4 };

            var shortestStr = arrOfStr.OrderBy(str => str.Length).FirstOrDefault();
            return shortestStr.Length;
            

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var arrOfNum = new int[] { number1, number2, number3, number4 };
            int ans = arrOfNum.Min();
            return ans;
           
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var triArr = new int[] { sideLength1, sideLength2, sideLength3 };
            foreach (var side in triArr)
            {
                if (side <= 0)
                {
                    return false;
                }
            }

            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            int num = 0;
            double dub = 0;
            bool isNum = int.TryParse(input, out num);
            bool isDouble = double.TryParse(input, out dub);
            if (isNum == true)
            {
                return true;
            }
            else if (isDouble == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var nullCount = 0;
            var majority = objs.Length / 2;
            foreach (var ob in objs)
            {
                if (ob == null)
                {
                    nullCount += 1;
                }
            }
            if (nullCount > majority)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public double AverageEvens(int[] numbers)
        {
            double numOfEvens = 0;
            double evenTotal = 0;

            if (numbers == null)
            {
                return 0;
            }
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    numOfEvens += 1;
                    evenTotal += num;
                }
            }
            if (numOfEvens > 0)
            {
              return evenTotal / numOfEvens;
            }
            else
            {
                return 0;
            }
            
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();   
            }
            var num = 1;
            for (int i = number; i > 0; i--)
            {
                num = num * i;
            }
            return num;
        }
    }
}
