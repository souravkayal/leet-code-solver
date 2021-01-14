using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy
{
    public class TwoSumUsingHash
    {
        public Dictionary<int, int> GetTowSum(int []Array ,int sum)
        {
            HashSet<int> hs = new HashSet<int>();
            Dictionary<int, int> result = new Dictionary<int, int>();

            foreach (var item in Array)
            {
                hs.Add(item);
            }

            for (int i = 0; i < Array.Length; i++)
            {
                int item = sum - Array[i];
                if(hs.Contains(item))
                {
                    if(!result.ContainsKey(Array[i]) && !result.ContainsKey(item))
                    {
                        result.Add(Array[i], item);
                    }
                }
            }
            return result;
        }
    }
}
