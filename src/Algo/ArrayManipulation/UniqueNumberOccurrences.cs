namespace Algo.ArrayManipulation;

public class UniqueNumberOccurrences
{
    public bool UniqueOccurrences(int[] arr)
    {
        
        Dictionary<int, int> set = new Dictionary<int, int>();

        foreach (var t in arr)
        {
            if (set.ContainsKey(t))
            {
                set[t] = set[t] + 1;
            }
            else set.Add(t, 1);
        }

        return set.Values.ToHashSet().Count == set.Count;
    }
}