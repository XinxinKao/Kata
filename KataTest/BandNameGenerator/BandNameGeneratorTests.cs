using NUnit.Framework;

namespace KataTest.BandNameGenerator
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
            var bandNameGenerator = new KataTest.BandNameGenerator.BandNameGenerator();
            var actual = bandNameGenerator.Generator(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}