using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if(vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else {
                return false;
                 }
                    //throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            
            if (num % 2 == 1 || num % 2 == -1 || num == 1 || num == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            if (numbers.Count() == 0 )
            {
                return 0;
            }


            else
            {
                return numbers.Max() + numbers.Min();
            }
            
            //throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            var ans = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                ans = ans + numbers[i];
            }
            return ans;
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            var ans = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    ans += numbers[i];
                }
            }
            return ans;
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            
            if (numbers == null)
            {
                return false;
            }

            var ans = 0;
            for (int i = 0; i < numbers.Count; i++)
            {

                    ans += numbers[i];
                
            }

            if (ans % 2 == 1 || ans % 2 == -1 || ans == 1 || ans == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
           // throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
