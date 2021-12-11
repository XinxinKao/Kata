using NUnit.Framework;

namespace KataTest.StringAverage
{
    [TestFixture]
    public class StringAverageTest
    {
        [TestCase("four", "zero nine five two")]
        [TestCase("three", "four six two three")]
        [TestCase("three", "one two three four five")]
        [TestCase("four", "five four")]
        [TestCase("zero", "zero zero zero zero zero")]
        [TestCase("two", "one one eight one")]
        [TestCase("n/a", "")]
        public void StringNumberAverageTest(string expected, string inputString)
        {
            var kata = new StringAverage();
            var actual = kata.AverageString(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}