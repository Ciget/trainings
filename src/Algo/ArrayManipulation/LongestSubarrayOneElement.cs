namespace Algo.ArrayManipulation;

//1493. Longest Subarray of 1's After Deleting One Element
public class LongestSubarrayOneElement
{
    public int LongestSubarray(int[] nums)
    {
        int start=0, zeroCount = 0, max=0;

        for (int i = 0; i < nums.Length; i++)
        {
            zeroCount += nums[i] == 0 ? 1 : 0;

            while (zeroCount > 1)
            {
                zeroCount -= nums[start] == 0 ? 1 : 0;
                start++;
            }

            max = Math.Max(max, i - start);
        }

        return max;
    }
}