using System.Text;

namespace Algo.StringManipulation;

public class ReverseWords557
{
    public string ReverseWords(string s)
    {
        var words = s.Split(" ");
        StringBuilder sb = new StringBuilder();
        for (int i=0; i<words.Length; i++)
        {
            sb.Append(Reverse(words[i]));
            if (i < words.Length - 1)
            {
                sb.Append(" ");
            }
        }

        return sb.ToString();
    }

    private string Reverse(string input)
    {
        string result = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result += input[i];
        }

        return result;
    }

    public string ReverseWords2(string s)
    {
        StringBuilder sb = new StringBuilder();

        string[] words = s.Split(' ');

        for (int i = words.Length-1; i>=0 ; i--)
        {
            if (words[i].Length == 0) continue;
            if (sb.Length > 0) sb.Append(" ");
            sb.Append(words[i]);
        }

        return sb.ToString();
    }
}