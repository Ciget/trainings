namespace Algo.StringManipulation;

public class StringCompressionEngine
{
    public int Compress(char[] chars)
    {
        if (chars.Length == 0) return 0;
        
        string result="";
        char currentChar=chars[0];
        int count=0;
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == currentChar)
            {
                count++;
            }
            else
            {
                result = result + currentChar + (count>1?count.ToString():"");
                count = 1;
                currentChar = chars[i];
            }
        }
        result = result + currentChar + (count>1?count.ToString():"");
        chars = result.ToCharArray();
        return result.Length;
    }
}