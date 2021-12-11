using NUnit.Framework;

namespace KataTest.DivisibilityRule
{
    [TestFixture]
    public class DivisibilityRuleTests
    {
        [TestCase(1021, new[] {10, 2})]
        public void RuleTest(int input, int[] expected)
        {
            var divSeven = new DivSeven();
            Assert.AreEqual(expected, divSeven.Seven(input));
        }
    }
}