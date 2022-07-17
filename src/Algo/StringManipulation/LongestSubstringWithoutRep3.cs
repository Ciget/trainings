namespace Algo.StringManipulation;

public class LongestSubstringWithoutRep3
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxRange = 0;
        Dictionary<char, int> _set = new Dictionary<char, int>();
        
        for (int i = 0, j = 0; j < n; j++)
        {
            if (_set.ContainsKey(s[j]))
            {
                i = Math.Max(_set[s[j]], i);
            }

            maxRange = Math.Max(maxRange, j - i + 1);
            if (_set.ContainsKey(s[j]))
            {
                _set[s[j]] = j+1;
            }
            else _set.Add(s[j], j+1);
        }

        return maxRange;
    }
}