﻿using System;

namespace ChallengeSets
{
    public class ChallengeSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            // throw new NotImplementedException();
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            // throw new NotImplementedException();
            var sub1 = minuend - subtrahend;

            return sub1;

        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            return number1 + number2;
            /*var add1 = number1 + number2;
            return add1;*/
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            //throw new NotImplementedException();
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        //public long Multiply(long factor 1, int factor2
        {
            //throw new NotImplementedException();
            var mul1n = factor1 * factor2;

            return mul1n;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();
            if (nameOfPerson.Length > 0)
            {
                return "Hello, " + nameOfPerson + "!";
            }
            else
            {
                return "Hello!";
            }

        }

        public string GetHey()
        {
            return "J9!";
        }
    }
}