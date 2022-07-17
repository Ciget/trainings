namespace Algo.StringManipulation;

public class RansomNote383
{
    public bool CanConstruct(string ransomNote, string magazine) {
        for (int i = 0; i < ransomNote.Length; i++)
        {
            int ind = magazine.IndexOf(ransomNote[i]);
            if (ind == -1) return false;

            magazine = magazine.Substring(0, ind) + magazine.Substring(ind + 1);
        }

        return true;
    }
}