
using System.Text;

namespace Algo.StringManipulation
{
    public class CompressString
    {
        public int Compress(char[] chars)
        {
            if (chars.Length == 0) return 0;

            string resultString ="";
            char currentChar = chars[0];
            int currentCharCount = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == currentChar)
                {
                    currentCharCount++;
                }
                else
                {
                    resultString += currentChar;
                    if (currentCharCount > 1)
                    {
                        resultString += currentCharCount;
                    }

                    currentChar = chars[i];
                    currentCharCount = 1;
                }
            }
            resultString += currentChar;
            if (currentCharCount > 1)
            {
                resultString += currentCharCount;
            }

            for (int i = 0; i < resultString.Length; i++)
            {
                chars[i] = resultString[i];
            }

            return resultString.Length;
        }
    }
}
