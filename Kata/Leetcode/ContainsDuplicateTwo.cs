namespace Kata.Leetcode
{
    public class ContainsDuplicateTwo
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = nums.Length - 1; j > 0; j--)
                {
                    if (nums[i] == nums[j] && i != j)
                    {
                        return (j - i) <= k;
                    }
                }
            }
            return false;
        }
    }
}