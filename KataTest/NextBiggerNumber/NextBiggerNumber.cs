using System.Collections.Generic;
using System.Linq;

namespace KataTest.NextBiggerNumber
{
    public static class NextBiggerNumber
    {
        public static long GetNextBiggerNumber(long input)
        {
            var inputString = input.ToString();

            if (input <= 11)
            {
                return -1;
            }

            var inputArray = inputString.ToCharArray();

            var number = GetNumber(inputArray);

            return number;
        }
        
        private static long GetNumber(IEnumerable<char> inputArray)
        {
            var list = inputArray.Select(x => int.Parse((string) x.ToString())).ToList();
            for (var i = list.Count - 1; i >= 1; i--)
            {
                if (list[i] > list[i - 1])
                {
                    var tmp = list[i];
                    list[i] = list[i - 1];
                    list[i - 1] = tmp;
                    break;
                }
            }

            var result = long.Parse(string.Join("", list));

            return result;
        }

    }
}