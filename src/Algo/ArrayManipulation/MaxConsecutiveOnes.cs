namespace Algo.ArrayManipulation
{
    //1004. Max Consecutive Ones III
    public class MaxConsecutiveOnes
    {
        //sliding window approach
        public int LongestOnes(int[] nums, int k)
        {
            int maxCount = 0;
            int left = 0, right = 0;

            for (; right < nums.Length; right++)
            {
                k += nums[right] == 0 ? -1 : 0;
                if (k < 0)
                {
                    k += nums[left] == 0 ? 1 : 0;
                    left++;
                }
                else
                {
                    maxCount = Math.Max(maxCount, right - left + 1);
                }
            }
            return maxCount;
        }
    }
}
