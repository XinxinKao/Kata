﻿using NUnit.Framework;

namespace KataTest.NextBiggerNumber
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [TestCase(11, -1)]
        [TestCase(12, 21)]
        [TestCase(513, 531)]
        [TestCase(2017, 2071)]
        [TestCase(414, 441)]
        [TestCase(144, 414)]
        public void NextBiggerNumberTest(int num, int expected)
        {
            var nextBiggerNumber = new NextBiggerNumber();
            var actual = nextBiggerNumber.GetNextBiggerNumber(num);
            Assert.AreEqual((long) expected, actual);
        }
    }
}