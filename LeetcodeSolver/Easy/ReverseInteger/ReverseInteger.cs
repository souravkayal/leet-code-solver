using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy
{
    public class ReverseInteger
    {
        public int GetReverseInteger(int number)
        {
            int sum = 0;
            bool isNegative = false;

            //Handle negative number
            if (number < 0)
            {
                isNegative = true;
                number = number * -1;
            }

            while (number > 0)
            {
                int r = number % 10;
                sum = sum * 10 + r;
                number = number / 10;
            }

            if (isNegative)
                sum = sum * -1;

            return sum;
        }
    }
}
