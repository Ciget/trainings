using System.Text;

namespace Algo;

//12. Integer to Roman
public class IntToRoman
{
    private static readonly Dictionary<int, string> _set = new Dictionary<int, string>
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" }
    };
    public string ConvertToRoman(int num)
    {
        StringBuilder sb = new StringBuilder();
        
        foreach (int k in _set.Keys)
        {
            while (k <= num)
            {
                sb.Append(_set[k]);
                num -= k;
            }
        }

        return sb.ToString();
    }
}