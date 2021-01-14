using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy
{
    /// <summary>
    /// Two sum problem 
    /// Find all pair which sums up to some number. Using traditional bruteforce
    /// </summary>
    public class TwoSumbruteForce
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        public bool CheckExist(int i, int j)
        {
            foreach (var item in result)
            {
                if((item.Item1 == i && item.Item2 == j) || (item.Item1 == j && item.Item2 == i))
                {
                    return true;
                }
            }
            return false;
        }
        public List<Tuple<int, int>> GetTwoSum(int []Array , int sum)
        {

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length; j++)
                {
                    if( i != j)
                    {
                        if(Array[i] + Array[j] == sum)
                        {
                            if(!CheckExist(Array[i], Array[j]))
                            {
                                result.Add(new Tuple<int, int>(Array[i], Array[j]));
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
