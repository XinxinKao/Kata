using System.Collections.Generic;
using System.Linq;

namespace KataTest.LeastCommonMultiple
{
    public static class LeastCommonMultiple
    {
        public static int Lcm(List<int> nums)
        {
            if (nums.Contains(0))
            {
                return 0;
            }
            if (!nums.Any())
            {
                return 1;
            }
            
            var result = 1;
            
            foreach (var item in nums)
            {
                result = result / GreatestCommonFactor(result, item) * item;
            }
            
            return result;
        }
        
        private static int GreatestCommonFactor(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}