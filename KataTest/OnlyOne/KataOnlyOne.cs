using System.Linq;

namespace KataTest.OnlyOne
{
    public class KataOnlyOne
    {
        public static bool OnlyOne(params bool[] flags)
        {
            var count = flags?.Where(x => x).Count();
            return count == 1;
        }
    }
}