using System;
using System.Text.RegularExpressions;

namespace KataTest.SumString
{
    public static class KataSumString
    {
        public static string SumStrings(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return string.Empty;
            }

            if (IsStringWithAlphabet(a) || IsStringWithAlphabet(b))
            {
                return string.Empty;
            }

            if (IsBothInputLengthSame(a, b))
            {
                return string.Empty;
            }

            var aArray = a.ToCharArray();
            var bArray = b.ToCharArray();
            var outputArray = new string[a.Length];
            for (var i = 0; i < a.Length; i++)
            {
                outputArray[i] = (Convert.ToInt32(aArray[i].ToString()) + Convert.ToInt32(bArray[i].ToString()))
                    .ToString();
            }

            return string.Join("", outputArray);
        }

        private static bool IsBothInputLengthSame(string a, string b)
        {
            return a.Trim().Length != b.Trim().Length;
        }

        private static bool IsStringWithAlphabet(string input)
        {
            const string pattern = @"[^0-9]";
            var rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            return rgx.IsMatch(input);
        }
    }
}