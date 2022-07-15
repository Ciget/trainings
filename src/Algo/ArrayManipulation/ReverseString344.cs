namespace Algo.ArrayManipulation;

public class ReverseString344
{
    public void ReverseString(char[] s) {
        int lenght = s.Length-1;
        for (int i = 0; i < s.Length; i++)
        {
            (s[i], s[lenght - i]) = (s[lenght - i], s[i]);
            if (lenght / 2 == i) break;
        }
    }
}