using System.Collections.Generic;
using System.Linq;

namespace KataTest.WordPatterns
{
    public static class WordPattern
    {
        public static bool Wp(string pattern, string str)
        {
            var charArray = pattern.ToCharArray();
            var inputString = str.Split(" ");
            var dictionary = new Dictionary<char, string>();
            if (charArray.Length != inputString.Length)
            {
                return false;
            }

            for (var i = 0; i < charArray.Length; i++)
            {
                if (!dictionary.ContainsKey(charArray[i]))
                {
                    dictionary.Add(charArray[i], inputString[i]);
                }

                if (dictionary.ContainsValue(inputString[i]) &&
                    GetKeyByValue(dictionary, inputString[i]) != charArray[i])
                {
                    return false;
                }

                if (dictionary[charArray[i]] != inputString[i])
                {
                    return false;
                }
            }

            return true;
        }

        private static char GetKeyByValue(Dictionary<char, string> dictionary, string value)
        {
            return dictionary.FirstOrDefault(x => x.Value == value).Key;
        }
    }
}