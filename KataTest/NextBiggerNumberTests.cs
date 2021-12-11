using Kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    public class NextBiggerNumberTests
    {
        [Test]
        public void TestNextBiggerNumber_When_Input_Is_11_Output_Will_Be_Negative_1()
        {
            var inputNumber = 11;
            var expected = -1;
            TestNextBiggerNumber(expected, inputNumber);
        }

        [Test]
        public void TestNextBiggerNumber_When_Input_Is_12_Output_Will_Be_21()
        {
            var inputNumber = 12;
            var expected = 21;
            TestNextBiggerNumber(expected, inputNumber);
        }

        [Test]
        public void TestNextBiggerNumber_When_Input_Is_513_Output_Will_Be_531()
        {
            var inputNumber = 513;
            var expected = 531;
            TestNextBiggerNumber(expected, inputNumber);
        }

        [Test]
        public void TestNextBiggerNumber_When_Input_Is_2017_Output_Will_Be_2071()
        {
            var inputNumber = 2017;
            var expected = 2071;
            TestNextBiggerNumber(expected, inputNumber);
        }

        [Test]
        public void TestNextBiggerNumber_When_Input_Is_414_Output_Will_Be_441()
        {
            var inputNumber = 414;
            var expected = 441;
            TestNextBiggerNumber(expected, inputNumber);
        }

        [Test]
        public void TestNextBiggerNumber_When_Input_Is_144_Output_Will_Be_414()
        {
            var inputNumber = 144;
            var expected = 414;
            TestNextBiggerNumber(expected, inputNumber);
        }

        private void TestNextBiggerNumber(long expected, long inputNumber)
        {
            var nextBiggerNumber = new NextBiggerNumber();
            var actual = nextBiggerNumber.GetNextBiggerNumber(inputNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}