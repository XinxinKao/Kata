﻿using System;
using Kata;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KataTest
{
    [TestFixture]
    public class KataSumStringTest
    {
        [Test]
        public void Given_123_And_456_Returns_579()
        {
            Assert.AreEqual("579", KataSumString.SumStrings("123", "456"));
        }

        [Test]
        public void Given_123a_And_4567_Returns_Empty()
        {
            Assert.AreEqual(string.Empty, KataSumString.SumStrings("123a", "4567"));
        }

        [Test]
        public void Given_1234_And_456a_Returns_Empty()
        {
            Assert.AreEqual(string.Empty, KataSumString.SumStrings("1234", "456a"));
        }

        [Test]
        public void Given_1234_And_456_Returns_Empty()
        {
            Assert.AreEqual(string.Empty, KataSumString.SumStrings("1234", "456"));
        }

        [Test]
        public void Given_1234_And_4321_Returns_5555()
        {
            Assert.AreEqual("5555", KataSumString.SumStrings("1234", "4321"));
        }
    }
}
