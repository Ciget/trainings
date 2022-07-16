namespace Algo.ArrayManipulation;

public class MergeSortedArrays88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums1[i + m] = nums2[i];
        }
        Array.Sort(nums1);
    }
}