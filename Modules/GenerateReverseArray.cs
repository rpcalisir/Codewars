using System.Linq;

namespace Modules
{
    public static class GenerateReverseArray
    {
        /// <summary>
        /// Build a function that returns an array of integers from n to 1 where n>0.
        ///Example : n=5 >> [5,4,3,2,1]
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }
    }
}
