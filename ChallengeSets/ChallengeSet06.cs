using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            {
                if (words == null || words.Contains(null))
                {
                    return false;
                }
                if (ignoreCase)
                {
                    foreach (var w in words)
                    {
                        if (w.ToLower() == word.ToLower())
                        {
                            return true;
                        }
                    }
                }
                return words.Contains(word);
            }
        }

        public bool IsPrimeNumber(int num)
        {

            throw new NotImplementedException();
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            throw new NotImplementedException();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            throw new NotImplementedException();
        }
    }
}