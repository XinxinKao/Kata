using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class BandNameGeneratorTests
    {
        [TestCase("The Knife", "knife")]
        [TestCase("Tartart", "tart")]
        [TestCase("Sandlesandles", "sandles")]
        [TestCase("The Bed", "bed")]
        public void BandNameGeneratorTestCase(string expected, string inputString)
        {
            var bandNameGenerator = new BandNameGenerator();
            var actual = bandNameGenerator.Generator(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}