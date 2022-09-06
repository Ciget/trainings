using System;
namespace Algo.StringManipulation
{
    public class DecodeStringTask
    {
        Stack<char> _stack = new Stack<char>();

        public string DecodeString(string s)
        {
            string result = "";
            char currentChar;
            _stack.Clear();

            for (int index = 0; index < s.Length; index++)
            {
                if (s[index] != ']')
                {
                    _stack.Push(s[index]);
                    continue;
                }

                //handle ]
                string decodeStr = "";
                int k = 0;
                //get string

                while (_stack.Count>0)
                {
                    currentChar = _stack.Pop();
                    if (currentChar == '[') break;
                    decodeStr = currentChar + decodeStr;
                }

                //get number
                int tempNumber = 0;
                string stringNumber = "";
                while (_stack.Count>0 && int.TryParse(_stack.Peek().ToString(),out tempNumber))
                {
                    stringNumber = _stack.Pop()+ stringNumber;
                }
                int.TryParse(stringNumber, out tempNumber);

                for (int i = 0; i < tempNumber; i++)
                {
                    for (int j = 0; j < decodeStr.Length; j++)
                    {
                        _stack.Push(decodeStr[j]);
                    }
                }
            }

            while (_stack.Count > 0)
            {
                result = _stack.Pop()+ result;
            }
            return result;
        }
    }
}

