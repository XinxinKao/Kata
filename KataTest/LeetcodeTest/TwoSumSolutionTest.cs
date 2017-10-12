using Kata.Leetcode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace KataTest.LeetcodeTest
{
    [TestFixture]
    public class TwoSumSolutionTest
    {
        [TestCase(9, new[] { 2, 7, 11, 5 }, new[] { 0, 1 }, TestName = "Test_TwoSum_2_7_11_5_And_Target_9_Should_Return_0_1")]
        [TestCase(12, new[] { 2, 7, 11, 5 }, new[] { 1, 3 }, TestName = "Test_TwoSum_2_7_11_5_And_Target_12_Should_Return_1_3")]
        [TestCase(10, new[] { 2, 7, 3, 5 }, new[] { 1, 2 }, TestName = "Test_TwoSum_2_7_3_5_And_Target_10_Should_Return_1_2")]
        [TestCase(10, new[] { 2, 1, 3, 0 }, new int[] { }, TestName = "Test_TwoSum_2_1_3_0_And_Target_10_Should_Return_Empty_Array")]
        [TestCase(10, new[] { 2 }, new int[] { }, TestName = "Test_TwoSum_2_And_Target_10_Should_Return_Empty_Array")]
        [TestCase(6, new[] { 3, 2, 4 }, new[] { 1, 2 }, TestName = "Test_TwoSum_3_2_4_And_Target_6_Should_Return_1_2")]
        public void Test(int sum, int[] input, int[] output)
        {
            var actual = TwoSumSolution.TwoSum(input, sum);
            var expected = output;
            Assert.AreEqual(expected, actual);
        }
    }
}
