using NUnit.Framework;

namespace KataTest.NextBiggerNumber
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [TestCase(11, -1)]
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        public void NextBiggerNumberTest(long num, long expected)
        {
            var actual = NextBiggerNumber.GetNextBiggerNumber(num);
            Assert.AreEqual(expected, actual);
        }
    }
}