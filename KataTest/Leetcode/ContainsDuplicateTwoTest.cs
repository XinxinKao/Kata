using Kata.Leetcode;
using NUnit.Framework;

namespace KataTest.Leetcode
{
    [TestFixture]
    public class ContainsDuplicateTwoTest
    {
        [Test]
        public void Test_ContainsDuplicateTwo_Input_Array_is_Empty_And_0_Output_Is_False()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { };
            var k = 0;
            var excepted = false;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        public void Test_ContainsDuplicateTwo_Input_Array_is_123_And_0_Output_Is_False()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { 1, 2, 3 };
            var k = 0;
            var excepted = false;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        public void Test_ContainsDuplicateTwo_Input_Array_is_12341_And_2_Output_Is_False()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { 1, 2, 3, 4, 1 };
            var k = 2;
            var excepted = false;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }

        [Test]
        public void Test_ContainsDuplicateTwo_Input_Array_is_12341_And_5_Output_Is_True()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { 1, 2, 3, 4, 1 };
            var k = 5;
            var excepted = true;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }
    }
}