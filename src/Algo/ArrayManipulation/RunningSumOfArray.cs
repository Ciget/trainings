using System;
namespace Algo.ArrayManipulation
{
	public class RunningSumOfArray
	{
        public int[] RunningSum(int[] nums)
        {
            if (nums.Length == 0) return nums;

            int[] result = new int [nums.Length];
            result[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = nums[i] + result[i - 1];
            }
            return result;
        }
    }
}

