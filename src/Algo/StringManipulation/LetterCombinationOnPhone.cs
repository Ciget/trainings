namespace Algo.StringManipulation;

//17. Letter Combinations of a Phone Number
public class LetterCombinationOnPhone
{
    private Dictionary<char, string> _set;

    public LetterCombinationOnPhone()
    {
        _set = new Dictionary<char, string>();
        _set.Add('2',"abc");
        _set.Add('3', "def");
        _set.Add('4', "ghi");
        _set.Add('5', "jkl");
        _set.Add('6', "mno");
        _set.Add('7', "pqrs");
        _set.Add('8', "tuv");
        _set.Add('9', "wxyz");
    }
    public IList<string> LetterCombinations(string digits)
    {
        List<string> result = new List<string>();

        if (digits.Length == 0) return result;
        
        Search("", 0, digits, result);

        return result;
    }

    private void Search(string combination, int index, string digits, List<string> result)
    {
        if (index == digits.Length)
        {        result.Add(combination);
            return;
        }

        var letters = _set[digits[index]];
        foreach(char l in letters)
        {
            Search(combination+l, index +1, digits, result);
        }
    }
}