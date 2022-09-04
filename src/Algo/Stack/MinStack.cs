using System;
namespace Algo.Stack
{
    public class MinStack
    {
        Stack<int> _stack = new Stack<int>();
        Stack<int> _minStack = new Stack<int>();

        public void Push(int val)
        {
            _stack.Push(val);
            int minObj;

            if (!_minStack.TryPeek(out minObj) || minObj >= val)
            {
                _minStack.Push(val);
            }
        }

        public void Pop()
        {
            var topEl = _stack.Pop();
            if (_minStack.Peek() == topEl)
            {
                _minStack.Pop();
            }
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _minStack.Peek();
        }
    }
}

