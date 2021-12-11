using NUnit.Framework;

namespace KataTest.OnlyOne
{
    [TestFixture]
    public class KataOnlyOneTest
    {
        [TestCase(false, null)]
        [TestCase(true, new[] { true, false, false })]
        [TestCase(false, new[] { true, false, false, true })]
        [TestCase(false, new[] { false, false, false, false })]
        public void Test1(bool expected,bool[] input)
        {
            Assert.AreEqual(expected, KataOnlyOne.OnlyOne(input));
        }
    }
}