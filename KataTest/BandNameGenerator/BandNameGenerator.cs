namespace KataTest.BandNameGenerator
{
    public class BandNameGenerator
    {
        public string Generator(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
                return null;

            var lowerInputString = inputString.Trim().ToLower();
            var head = lowerInputString.Substring(0, 1).ToUpper();
            var body = lowerInputString.Substring(1);
            var text = head + body;
            if (lowerInputString.Substring(0, 1) == lowerInputString.Substring(lowerInputString.Length - 1))
            {
                return text + body;
            }

            return "The " + text;
        }
    }
}