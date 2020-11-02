using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();
            foreach (bool b in vals)
            {
                if (!b)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
         {
             //throw new NotImplementedException();
             if (numbers == null || numbers.Count() == 0)
             {
                 return false;
             }
             int sum = 0;
             foreach (int i in numbers)
             {
                 if (i % 2 == 1 || i % 2 == -1)
                 {
                     sum += i;
                 }
             }
             if (sum % 2 == 1 || sum % 2 == -1)
            {
                return true;
            }

            return false;  
         }
        
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            if (password.Any(char.IsUpper)&&
                password.Any(char.IsLower)&&
                password.Any(char.IsNumber))
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            //throw new NotImplementedException();
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();
            return nums[nums.Length - 1] - nums[0];
        }
        public int[] GetOddsBelow100()
        {
            //throw new NotImplementedException();
            int[] odds = new int[50];
                for (int i =0, index = 0; i < 100; i++)
            {
                if (i % 2 == 1)
                {
                    odds[index] = i;
                    index++;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();
            for (int i = 0; i <words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
