using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class CountingDuplicates
    {
        public int DuplicateCount(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            var count = 0;
            str = str.ToLower();

            foreach (var index in str.ToCharArray())
            {
                if (str.Count(x => x == index) < 2) continue;
                count++;
                str = str.Replace(index.ToString(), "");
            }

            return count;

            //Kata Best Practice:
            //return str.ToLower().GroupBy(x => x).Count(g => g.Count() > 1);
        }
    }
}
