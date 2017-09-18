using Kata.Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTest.LeetcodeTest
{
    [TestClass]
    public class ContainsDuplicateTwoTest
    {
        [TestMethod]
        public void Test_ContainsDuplicateTwo_Input_Array_is_Empty_And_0_Output_Is_False()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { };
            var k = 0;
            var excepted = false;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_ContainsDuplicateTwo_Input_Array_is_123_And_0_Output_Is_False()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { 1, 2, 3 };
            var k = 0;
            var excepted = false;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void Test_ContainsDuplicateTwo_Input_Array_is_12341_And_2_Output_Is_False()
        {
            var target = new ContainsDuplicateTwo();
            var nums = new int[] { 1, 2, 3, 4, 1 };
            var k = 2;
            var excepted = false;
            var actual = target.ContainsNearbyDuplicate(nums, k);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
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
