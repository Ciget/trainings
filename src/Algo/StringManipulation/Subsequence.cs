using System;
namespace Algo.StringManipulation
{
	public class Subsequence
	{
        public bool IsSubsequence(string s, string t)
        {
            
            int indexPos = 0;

            if (s.Length == 0) return true;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == s[indexPos])
                {
                    indexPos++;
                    if (indexPos >= s.Length) return true;
                }
            }
            return false;
        }
    }
}

