namespace Algo.StringManipulation;

public class ReverseVowelsEngine
{
    //345. Reverse Vowels of a String
    public string ReverseVowels(string s)
    {
        char[] results = s.ToCharArray();
        int rightIndex = results.Length - 1;
        for (int i = 0; i < rightIndex; i++)
        {
            if (!IsItVowel(results[i])) continue;
            
            for (; rightIndex > i; rightIndex--)
            {
                if (IsItVowel(results[rightIndex]))
                {
                    (results[i], results[rightIndex]) = (results[rightIndex], results[i]);
                    rightIndex--;
                    break;
                }

            }
        }
//reca car
        return new string(results);
    }

    private bool IsItVowel(char c)
    {
        char[] vowels = new[] {'a', 'o', 'e', 'i', 'u', 'A', 'O', 'E', 'I', 'U'};

        foreach (var t in vowels)
        {
            if (t == c) return true;
        }

        return false;
    }
}