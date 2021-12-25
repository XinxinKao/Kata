using System.Collections.Generic;
using NUnit.Framework;

namespace KataTest.LeastCommonMultiple
{
    [TestFixture]
    public class LeastCommonMultipleTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual(10, LeastCommonMultiple.Lcm(new List<int> {2, 5}));
            Assert.AreEqual(9, LeastCommonMultiple.Lcm(new List<int> {9}));
            Assert.AreEqual(12, LeastCommonMultiple.Lcm(new List<int> {2, 3, 4}));
        }
    }
}