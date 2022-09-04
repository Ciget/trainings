using System;
namespace Algo.StringManipulation
{
    public class TextJustification
    {
        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = new List<string>();
            int leftPosition =0, bufferSize=0, wordCount=0;

            for (int i = 0; i < words.Length; i++)
            {
                if (bufferSize + words[i].Length + i - leftPosition > maxWidth)
                {
                    result.Add(FormLine(words, leftPosition, i - 1, bufferSize, maxWidth));
                    leftPosition = i;
                    bufferSize = 0;
                }
                else
                {
                    bufferSize += words[i].Length;
                }

                if (i == words.Length - 1)
                {
                    bufferSize += words[i].Length;
                    result.Add(FormLine(words, leftPosition, i, bufferSize, maxWidth));
                }
            }
            return result;
        }

        private string FormLine(string[] inputString, int startIndex, int stopIndex, int textLength, int maxWidth)
        {
            string result = "";

            int spacesCount = (maxWidth - textLength);
            int lastSpaceCount = (maxWidth - textLength);
            if (stopIndex - startIndex > 0)
            {
                spacesCount /= (stopIndex - startIndex);
                lastSpaceCount %= (stopIndex - startIndex);
            }
           
            for (int i = startIndex; i <= stopIndex; i++)
            {
                if (i > startIndex)
                {
                    if (i == stopIndex)
                    {
                        result += new string(' ', lastSpaceCount == 0 ? spacesCount : lastSpaceCount) ;
                    }
                    else result += new string(' ', spacesCount);
                }
                result += inputString[i];
            }

            return result;
        }
    }
}

