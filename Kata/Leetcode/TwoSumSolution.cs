namespace Kata.Leetcode
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var length = nums.Length;

            if (length < 2)
            {
                return new int[0];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (target == nums[i] + nums[j])
                    {
                        return new[] {i, j};
                    }
                }
            }

            return new int[0];
        }
    }
}