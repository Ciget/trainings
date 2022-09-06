using System;
namespace Algo.Stack
{
    /// <summary>
    /// Task #150
    /// </summary>
    public class EvaluateReversePolishNotation
    {
        Stack<int> _stack = new Stack<int>();

        public int EvalRPN(string[] tokens)
        {
            _stack.Clear();

            for (int index = 0; index < tokens.Length; index++)
            {
                if (tokens[index] == "+")
                {
                    int var2 = _stack.Pop();
                    int var1 = _stack.Pop();
                    _stack.Push(var1 + var2);
                }
                else if (tokens[index] == "-")
                {
                    int var2 = _stack.Pop();
                    int var1 = _stack.Pop();
                    _stack.Push(var1 - var2);
                }
                else if (tokens[index] == "*")
                {
                    int var2 = _stack.Pop();
                    int var1 = _stack.Pop();
                    _stack.Push(var1 * var2);
                }
                else if (tokens[index] == "/")
                {
                    int var2 = _stack.Pop();
                    int var1 = _stack.Pop();
                    _stack.Push(var1 / var2);
                }
                else
                {
                    _stack.Push(int.Parse(tokens[index]));
                }
            }

            return _stack.Pop();
        }
    }
}

