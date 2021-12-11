using System.Collections.Generic;
using System.Linq;

namespace KataTest.StringAverage
{
    public class StringAverage
    {
        private readonly Dictionary<string, int> _numberLookup = new Dictionary<string, int>()
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9}
        };

        public string AverageString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "n/a";
            }
            
            var numbers = input.Split(' ');
            
            var total = ConvertToInt(numbers).Sum();

            var average = total / numbers.Length;

            return GetNumberFromLookup(average);
        }

        private string GetNumberFromLookup(int average)
        {
            return _numberLookup.FirstOrDefault(x => x.Value == average).Key;
        }

        private IEnumerable<int> ConvertToInt(IEnumerable<string> numberString)
        {
            return numberString.Select(item => _numberLookup[item]);
        }
    }
}