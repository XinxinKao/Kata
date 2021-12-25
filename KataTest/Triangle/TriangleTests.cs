using NUnit.Framework;

namespace KataTest.Triangle
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(5,7,10, true)]
        [TestCase(-1,2,3, false)]
        [TestCase(1,-2,3, false)]
        [TestCase(1,2,-3, false)]
        [TestCase(1,2,4, false)]
        [TestCase(4,1,2, false)]
        [TestCase(1,4,2, false)]
        [TestCase(1,2,3, false)]
        [TestCase(3,1,2, false)]
        [TestCase(1,3,2, false)]
        [TestCase(3,4,5, true)]
        public void IsTriangleTest(int a, int b, int c, bool expected)
        {
            Assert.AreEqual(expected,Triangle.IsTriangle(a, b, c));
        }
    }
}