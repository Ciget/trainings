namespace Algo.ArrayManipulation;

//1268. Search Suggestions System
public class SearchSuggestionSystem
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        Array.Sort(products);
        List<string> prodList = new List<string>(products);
        IList<IList<string>> result = new List<IList<string>>();
        for (int i = 1; i <= searchWord.Length; i++)
        {
            var subString = searchWord.Substring(0, i);
            var t = prodList.Where(x => x.StartsWith(subString)).Take(3).ToList();
            result.Add(t);
        }

        return result;
    }
}