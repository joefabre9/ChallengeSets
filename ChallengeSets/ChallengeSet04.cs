
//ChallengeSets worked on by Joe Fabre
//Nov 3 2020
using System;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    sum -= i;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            int shortestLength = 100000;
            if (str1.Length < shortestLength)
            {
                shortestLength = str1.Length;
            }
            if (str2.Length < shortestLength)
            {
                shortestLength = str2.Length;
            }
            if (str3.Length < shortestLength)
            {
                shortestLength = str3.Length;
            }
            if (str4.Length < shortestLength)
            {
                shortestLength = str4.Length;
            }
            return shortestLength;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //throw new NotImplementedException();
            int lowestValue = 100000;
            if (number1 < lowestValue)
            {
                lowestValue = number1;
            }
            if (number2 < lowestValue)
            {
                lowestValue = number2;
            }
            if (number3 < lowestValue)
            {
                lowestValue = number3;
            }
            if (number4 < lowestValue)
            {
                lowestValue = number4;
            }
            return lowestValue;
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
