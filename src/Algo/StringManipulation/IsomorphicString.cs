using System;
namespace Algo.StringManipulation
{
	public class IsomorphicString
	{
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            Dictionary<char, char> hash = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (hash.ContainsKey(s[i]))
                {
                    if (hash[s[i]] != t[i]) return false;
                }
                else
                {
                    if (hash.ContainsValue(t[i])) return false;
                    else hash.Add(s[i], t[i]);
                }
            }
            return true;
        }
    }
}