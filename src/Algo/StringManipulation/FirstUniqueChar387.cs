namespace Algo.StringManipulation;

public class FirstUniqueChar387
{
    public int FirstUniqChar(string s)
    {
        Dictionary<char, int> _set = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (_set.ContainsKey(s[i]))
            {
                _set[s[i]] += 1;
            }
            else _set.Add(s[i], 1);
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (_set[s[i]] == 1)
                return i;
        }

        return -1;
    }
}