using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy.TwoSum
{
    /// <summary>
    /// Implementation of two sum using sorting
    /// </summary>
    public class TwoSumUsingSorting
    {
        public Dictionary<int, int> GetTwoSum(int []Array, int key)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            //Sort array using bubble sort O(n^2). We can optimize with O(nlog(n))
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length; j++)
                {
                    if(Array[i] > Array[j])
                    {
                        int tmp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = tmp;
                    }
                }
            }
            //
            for (int i = 0 , j = Array.Length -1; i < j;)
            {
                int sum = Array[i] + Array[j];
                if (sum == key)
                {
                    result.Add(Array[i], Array[j]);
                }
                else if (sum < key)
                {
                    ++i;
                }
                else
                    --j;
            }

            return result;
        }

    }
}
