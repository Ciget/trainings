using System;
namespace Algo.Stack
{
    public class ValidParenthesesString
    {
        Stack<char> _stack = new Stack<char>();

        public bool IsValid(string s)
        {
            foreach (var ch in s)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    _stack.Push(ch);
                }
                if ((ch == ')' || ch == ']' || ch == '}') && _stack.Count == 0)
                {
                    return false;
                }

                if (ch == ')')
                {
                    if (_stack.Pop() != '(') return false;
                }
                else if (ch == '}')
                {
                    if (_stack.Pop() != '{') return false;
                }
                else if (ch == ']')
                {
                    if (_stack.Pop() != '[') return false;
                }
            }
            return _stack.Count==0;
        }
    }
}

