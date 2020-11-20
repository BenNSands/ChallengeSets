using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }
            foreach (var boo in vals)
            {
                if (boo == false)
                {
                    return true;
                }
                
            }
            return false;
           // throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            var ans = 0;
            if(numbers == null)
            {
                return false;
            }
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    ans += num;
                }
            }
            if(ans % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var upp = 0;
            var digi = 0;
            var low = 0;
            foreach (var condis in password)
            {
                    if (char.IsUpper(condis) && upp == 0)
                    {
                      upp++;
                    }
            }

            foreach (var condis in password)
            {
                if (char.IsLower(condis) && low == 0)
                {
                        low++;
                }

            }
            foreach (var condis in password)
            {
                if (char.IsDigit(condis) && digi == 0)
                {
                        digi++;
                }

            }

            var ans = digi + upp + low;

            if (ans == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
            //throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            var ans = val.Length - 1;
            return val[ans];
            //throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;  
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            var last = nums.Length - 1;

            var ans = nums[last] - nums[0];
            return ans;
            //throw new NotImplementedException();
        }
        public int[] GetOddsBelow100()
        {
            var list = new List<int>();

            for (int i = 1; i < 100; i+=2)
            {
                list.Add(i);
            }
            return list.ToArray();




           
           // throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            for(int i = 0; i < words.Length; i++)
            {
               words[i] = words[i].ToUpper();
            }
            //throw new NotImplementedException();
        }
    }
}
