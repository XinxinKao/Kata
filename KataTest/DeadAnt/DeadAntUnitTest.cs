using NUnit.Framework;

namespace KataTest.DeadAnt
{
    [TestFixture]
    public class DeadAntUnitTest
    {
        [TestCase(0, "ant ant ant ant")]
        [TestCase(0, null)]
        [TestCase(2, "ant anantt aantnt")]
        [TestCase(1, "ant ant .... a nt")]
        public void DeadAntCountFromStringTest2(int expected, string inputString)
        {
            var deadAnt = new KataTest.DeadAnt.DeadAnt();
            var actual = deadAnt.DeadAntCount(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}