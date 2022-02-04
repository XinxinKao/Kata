using System.Collections.Generic;

namespace KataTest.ReversedSequence
{
    public static class ReversedSequence
    {
        public static IEnumerable<int> ReverseSeq(int n)
        {
            for (var i = n; i > 0; i--)
            {
                yield return i;
            }
        }
    }
}