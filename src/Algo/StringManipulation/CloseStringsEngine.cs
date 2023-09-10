namespace Algo.StringManipulation;

public class CloseStringsEngine
{
    //1657. Determine if Two Strings Are Close
    public bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length) return false;
        
        int[] one = new int[26];
        int[] two = new int[26];

        foreach(var ch in word1)
        {
            one[ch - 'a']++;
        }
        foreach(var ch in word2)
        {
            two[ch - 'a']++;
        }

        for (int i = 0; i < 26; i++)
        {
            if (one[i] == 0 ^ two[i] == 0) return false;
        }

        Array.Sort(one);
        Array.Sort(two);

        for (int i = 0; i < 26; i++)
        {
            if (one[i] != two[i]) return false;
        }

        return true;
    }
}