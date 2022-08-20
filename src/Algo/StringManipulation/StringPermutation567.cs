namespace Algo.StringManipulation;

public class StringPermutation567
{
    public bool checkInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        Dictionary<char, int> s1map = new Dictionary<char, int>();
        for (int i = 0; i < s1.Length; i++)
        {
            if (s1map.ContainsKey(s1[i])) s1map[s1[i]] +=1;
            else s1map.Add(s1[i], 1);
        }

        for (int i = 0; i < s2.Length-s2.Length; i++)
        {
            Dictionary<char, int> _temp = new Dictionary<char, int>();

            if (match(s1map, s2map))
            {
            }
        }

    }

    private bool match(Dictionary<char, int> s1, Dictionary<char, int> s2)
    {
    }
}