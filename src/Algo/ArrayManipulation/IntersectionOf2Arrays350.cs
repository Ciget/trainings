namespace Algo.ArrayManipulation;

public class IntersectionOf2Arrays350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> result = new List<int>();
        Dictionary<int, int> _set = new Dictionary<int, int>();
        
        for (int i = 0; i < nums1.Length; i++)
        {
            if (_set.ContainsKey(nums1[i])) _set[nums1[i]] += 1;
            else _set.Add(nums1[i], 1);
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (_set.ContainsKey(nums2[i]) && _set[nums2[i]] > 0)
            {
                result.Add(nums2[i]);
                _set[nums2[i]] -= 1;
            }
        }

        return result.ToArray();
    }
}