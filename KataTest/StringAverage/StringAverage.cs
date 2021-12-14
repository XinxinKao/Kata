using System;
using System.Linq;

namespace KataTest.StringAverage
{
    public class StringAverage
    {
        private readonly string[] _numberLookup = new[] {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        public string AverageString(string input)
        {
            var numberWords = input.Split();
            
            if (IsNotFitInNumberLookup(numberWords))
            {
                return "n/a";
            }
            
            return _numberLookup[(int)Math.Floor(numberWords.Select(x => Array.IndexOf(_numberLookup, x)).Average())];
        }

        private bool IsNotFitInNumberLookup(string[] numberWords)
        {
            return !numberWords.All(_numberLookup.Contains);
        }
    }
}