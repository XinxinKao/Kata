using NUnit.Framework;

namespace KataTest.WordPatterns
{
    [TestFixture]
    public class WordPatternTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, WordPattern.Wp("abab", "apple banana apple banana"));
            Assert.AreEqual(true, WordPattern.Wp("abba", "car truck truck car"));
            Assert.AreEqual(false, WordPattern.Wp("abab", "apple banana banana apple"));
            Assert.AreEqual(true, WordPattern.Wp("aaaa", "cat cat cat cat"));
            Assert.AreEqual(false, WordPattern.Wp("aaaa", "cat cat dog cat"));
            Assert.AreEqual(true, WordPattern.Wp("bbbabcb", "c# c# c# javascript c# python c#"));
            Assert.AreEqual(true, WordPattern.Wp("abcdef", "apple banana cat donkey elephant flower"));
            Assert.AreEqual(false, WordPattern.Wp("xyzzyx", "apple banana apple banana"));
            Assert.AreEqual(true, WordPattern.Wp("xyzzyx", "1 2 3 3 2 1"));
            Assert.AreEqual(true, WordPattern.Wp("aafggiilp", "cow cow fly pig pig sheep sheep chicken aardvark"));
            Assert.AreEqual(false,
                WordPattern.Wp("aafggiilp", "cow cow fly rooster pig sheep sheep chicken aardvark"));
            Assert.AreEqual(false, WordPattern.Wp("aaaa", "cat cat cat"));
            Assert.AreEqual(false, WordPattern.Wp("abba", "dog dog dog dog"));
        }
    }
}