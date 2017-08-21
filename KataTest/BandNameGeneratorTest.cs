using Kata;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KataTest
{
    [TestFixture]
    public class BandNameGeneratorTest
    {
        [TestCase("The Knife", "knife")]
        [TestCase("Tartart", "tart")]
        [TestCase("Sandlesandles", "sandles")]
        [TestCase("The Bed", "bed")]
        public void BandNameGeneratorTestCase(string expected, string inputString)
        {
            var nameGenerator = new BandNameGenerator();
            var actual = nameGenerator.Generator(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}
