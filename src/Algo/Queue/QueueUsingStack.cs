﻿using System;
namespace Algo.Queue
{
    public class QueueUsingStack
    {
        Stack<int> _stack1 = new Stack<int>();
        Stack<int> _stack2 = new Stack<int>();

        public QueueUsingStack()
        {
        }

        public void Push(int x)
        {
            while (_stack1.Count > 0)
            {
                _stack2.Push(_stack1.Pop());
            }
            _stack1.Push(x);

            while (_stack2.Count > 0)
            {
                _stack1.Push(_stack2.Pop());
            }
        }

        public int Pop()
        {
            return _stack1.Pop();
        }

        public int Peek()
        {
            return _stack1.Peek();
        }

        public bool Empty()
        {
            return _stack1.Count == 0;
        }
    }

    /**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
}

