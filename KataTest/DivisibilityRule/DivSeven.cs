namespace KataTest.DivisibilityRule
{
    public static class DivSeven
    {
        public static long[] Seven(long input)
        {
            var steps = 0;

            while (IsNumberOverTwoDigits(input))
            {
                input = GetNumberWithoutLastOne(input) - (GetLastOneNumber(input) * 2);
                steps++;
            }

            return new[] {input, steps};
        }

        private static bool IsNumberOverTwoDigits(long input)
        {
            return input > 99;
        }

        private static long GetLastOneNumber(long stepOneNumber)
        {
            return stepOneNumber % 10;
        }

        private static long GetNumberWithoutLastOne(long numberText)
        {
            return numberText / 10;
        }
    }
}