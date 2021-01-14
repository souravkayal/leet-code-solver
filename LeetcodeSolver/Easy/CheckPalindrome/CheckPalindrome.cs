using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy.CheckPalindrome
{
    public class CheckPalindrome
    {
        public bool CheckPalindromeNumber(int number)
        {
            return new ReverseInteger().GetReverseInteger(number) == number ? true : false;
        }
    }
}
