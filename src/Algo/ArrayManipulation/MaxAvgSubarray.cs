using System;

namespace Algo.ArrayManipulation
{
    //643. Maximum Average Subarray I
    public class MaxAvgSubarray
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            if (k<=0 || k > nums.Length) return 0;
            double sum = 0, avg=0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            avg = sum / k;

            if (k == nums.Length) return avg;
            for (int i = k; i < nums.Length; i++)
            {
                sum = sum - nums[i - k] + nums[i];
                if (avg < sum/k)
                { 
                    avg = sum/k;
                }
            }

            return avg;
        }
    }
}
