namespace Algo.ArrayManipulation;

public class DiffInTwoArrays
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);
        
        foreach(var val in set1)
        {
            if (set2.Contains(val))
            {
                set1.Remove(val);
                set2.Remove(val);
            }
        }

        IList<IList<int>> result = new List<IList<int>>();
        result.Add(set1.ToList());
        result.Add(set2.ToList());
        return result;
    }
}
