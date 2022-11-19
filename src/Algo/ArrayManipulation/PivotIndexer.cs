using System;
namespace Algo.ArrayManipulation
{
	public class PivotIndexer
	{
        public int PivotIndex(int[] nums)
        {
            int sum = 0;
            int leftSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (leftSum == sum - nums[i] - leftSum) return i;
                else {
                    leftSum += nums[i];
                }
            }

            return -1;
        }
    }
}

