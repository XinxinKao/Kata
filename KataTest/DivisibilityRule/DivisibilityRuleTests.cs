using NUnit.Framework;

namespace KataTest.DivisibilityRule
{
    [TestFixture]
    public class DivisibilityRuleTests
    {
        [TestCase(1021, new[] {10, 2})]
        [TestCase(1603, new[] {7, 2})]
        [TestCase(371, new[] {35, 1})]
        [TestCase(483, new[] {42, 1})]
        [TestCase(477557101, new[] {28, 7})]
        public void RuleTest(int input, int[] expected)
        {
            Assert.AreEqual(expected, DivSeven.Seven(input));
        }
    }
}