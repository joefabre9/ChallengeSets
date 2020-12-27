using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //throw new NotImplementedException();
            if (words == null) return false;
            foreach (var str in words)
            {
                if (str == null) continue;
                if (ignoreCase && word.ToLower() == str.ToLower())
                {
                    return true;
                }
                else if (!ignoreCase && word == str)
                {
                    return true;
                }
             }
                return false;
            }

        public bool IsPrimeNumber(int num)
        {
            //throw new NotImplementedException();
            if (num <= 1) return false;
            for (int i = 2; i < num; i++)
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

            int rnum = numbers[0];
            int rcount = 1;

            int currentCount = 0;
            int previousInt = int.MinValue;
            foreach (int number in numbers)
            {
                if (number != previousInt)
                {
                    currentCount = 1;
                }
                else
                {
                    currentCount++;
                }

                if (currentCount >= rcount)
                {
                    rnum = number;
                    rcount = currentCount;
                }

                previousInt = number;
            }

            return rnum;

        }
        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}