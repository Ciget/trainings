namespace Algo.StringManipulation;

//17. Letter Combinations of a Phone Number
public class LetterCombinationOnPhone
{
    private Dictionary<int, List<char>> _set;

    public LetterCombinationOnPhone()
    {
        _set = new Dictionary<int, List<char>>();
        _set.Add(2, new List<char>(new []{'a', 'b', 'c'}));
        _set.Add(3, new List<char>(new []{'d', 'e', 'f'}));
        _set.Add(4, new List<char>(new []{'g', 'h', 'i'}));
    }
    public IList<string> LetterCombinations(string digits)
    {
        
    }

    
}