﻿using NUnit.Framework;

namespace KataTest.CountingDuplicates
{
    [TestFixture]
    public class CountingDuplicatesTests
    {
        [TestCase(0, "")]
        [TestCase(0, "abcde")]
        [TestCase(2, "aabbcde")]
        [TestCase(2, "aabBcde")]
        [TestCase(1, "Indivisibility")]
        [TestCase(2, "Indivisibilities")]
        public void TestDuplicateCountUnitTest(int expected, string inputString)
        {
            var countingDuplicates = new KataTest.CountingDuplicates.CountingDuplicates();
            var actual = countingDuplicates.DuplicateCount(inputString);
            Assert.AreEqual(expected, actual);
        }
    }
}