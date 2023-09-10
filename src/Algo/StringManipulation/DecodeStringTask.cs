using System;
namespace Algo.StringManipulation
{
    public class DecodeStringTask
    {
        Stack<char> _stack = new Stack<char>();

        public string DecodeString(string s)
        {
            Stack<char> stack = new Stack<char>();
            char currentChar;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ']')
                {
                    stack.Push(s[i]);
                    continue;
                }

                string decoderString = "";
                while (stack.Count > 0)
                {
                    currentChar = stack.Pop();
                    if (currentChar == '[') break;
                    decoderString = decoderString + currentChar;
                }
                
                
            }
            

            return new string(stack.ToArray());
        }
    }
}

