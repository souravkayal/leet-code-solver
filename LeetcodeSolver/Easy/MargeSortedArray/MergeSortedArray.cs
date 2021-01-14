using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy.MargeSortedArray
{
    public class MergeSortedArray
    {
        public int [] MergeArray(int []Array1 , int []Array2)
        {
            int[] result = new int[Array1.Length + Array2.Length];
            int idx = 0;
            int i =0,  j =0;

            while (i< Array1.Length && j < Array2.Length )
            {
                if(Array1[i] < Array2[j])
                {
                    result[idx] = Array1[i];
                    ++i;
                }
                else if(Array1[i] > Array2[j])
                {
                    result[idx] = Array2[j];
                    ++j;
                }
                else if(Array1[i] == Array2[j])
                {
                    result[idx] = Array1[i];
                    ++idx;
                    result[idx] = Array2[j];
                    ++i;
                    ++j;
                }
                ++idx;
            }
            
            //take rest of the items
            if(i < Array1.Length)
            {
                while (i < Array1.Length)
                {
                    result[idx] = Array1[i];
                    ++idx;
                    ++i;
                }
            }

            if (j < Array2.Length)
            {
                while (j < Array2.Length)
                {
                    result[idx] = Array2[j];
                    ++idx;
                    ++j;
                }
            }

            return result;
        }
    }
}
