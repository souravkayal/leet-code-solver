using System;
using System.Collections.Generic;
using System.Text;

namespace LeetcodeSolver.Easy.ValidParentheses
{
    public class ValidateParentheses
    {
        //Validate parentheses 
        public bool ParenthesesValidator(string expression)
        {
            Stack<char> stk = new Stack<char>();
            bool isValid = true;

            foreach (var item in expression)
            {
                if (item == '(' || item == '{' || item == '[')
                    stk.Push(item);
                else
                {
                    char top = stk.Pop();
                    if ((item == ')' && top != '(') || (item == '}' && top != '{') || (item == ']' && top != '['))
                    {
                        isValid = false;
                        break;
                    }
                }
            }
            return isValid;
        }
    }
}
