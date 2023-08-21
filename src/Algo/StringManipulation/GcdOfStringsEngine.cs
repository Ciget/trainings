namespace Algo.StringManipulation;

public class GcdOfStringsEngine
{
    //Greatest Common Divisor of Strings
    public string GcdOfStrings(string str1, string str2)
    {
        if (str1 + str2 != str2 + str1) return "";

        return str1.Substring(0, GetGCD(str1.Length, str2.Length));
    }

    private int GetGCD(int b, int e)
    {
        return e == 0 ? b : GetGCD(e, b % e);
    }

}