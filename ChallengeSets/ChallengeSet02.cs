using System;
using System.Collections.Generic;
using System.Linq;


namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();
            return vals.Length %2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //***must get help on this one
            //throw new NotImplementedException();
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double minValue = 10000.00;
            double maxValue = 0;
            foreach (double dub in numbers.ToList())
            {
                if (dub < minValue)
                {
                    minValue = dub;
                }
                if (dub > maxValue)
                {
                    maxValue = dub;
                }
            }
            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
