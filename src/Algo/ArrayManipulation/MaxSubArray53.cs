namespace Algo.ArrayManipulation;

public class MaxSubArray53
{
    public int MaxSubArray(int[] nums)
    {
        int currentSubArray = nums[0];
        int maxSubArray = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSubArray = Math.Max(nums[i], currentSubArray + nums[i]);
            maxSubArray = Math.Max(maxSubArray, currentSubArray);
        }

        return maxSubArray;
    }
}