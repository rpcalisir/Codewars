using System.Collections.Generic;
using System.Linq;

namespace Modules
{
    /// <summary>
    /// Complete the method which returns the number which is most frequent in the given input array. 
    /// If there is a tie for most frequent number, return the largest number among them.
    /// Note: no empty arrays will be given.
    /// </summary>
    public static class HighestRankNumberInArray
    {
        /// <summary>
        /// We create a hash table and store elements and their frequency counts as key value pairs. 
        /// Finally we traverse the hash table and print the key with maximum value.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int HighestRank(int[] arr)
        {
            Dictionary<int, int> ht = new Dictionary<int, int>();

            int key, freq, result = 0, min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                key = arr[i];
                if (ht.ContainsKey(key))
                {
                    freq = ht[key];
                    freq++;
                    ht[key] = freq;
                }
                else
                {
                    ht.Add(key, 1);
                }
            }

            foreach (KeyValuePair<int, int> item in ht)
            {
                if (item.Value > min)
                {
                    min = item.Value;
                    result = item.Key;
                }
            }

            foreach (KeyValuePair<int, int> item in ht)
            {
                if (item.Value == min)
                {
                    if (item.Key > result)
                    {
                        result = item.Key;
                    }
                }
            }

            return result;


            // return arr
            //.GroupBy(i => i)
            //.OrderByDescending(gr => gr.Count())
            //.ThenByDescending(gr => gr.Key)
            //.Select(gr => gr.Key)
            //.First();

            //return arr.GroupBy(x => x).OrderBy(g => g.Count()).ThenBy(g => g.Key).Last().Key;

            //return arr.GroupBy(_ => _).Max(_ => (_.Count(), _.Key)).Key;

            //return arr.GroupBy(n => n).OrderByDescending(n => n.Count()).ThenByDescending(n => n.Key).Select(n => n.Key).First();
        }
    }
}
