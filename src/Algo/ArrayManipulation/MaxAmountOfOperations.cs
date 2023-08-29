
using System.Globalization;

namespace Algo.ArrayManipulation
{
    //1679. Max Number of K-Sum Pairs
    public class MaxAmountOfOperations
    {
        public int MaxOperations(int[] nums, int k)
        {
            if (nums.Length==0) return 0;
            Array.Sort(nums);
            int li = 0, ri = nums.Length-1;
            int operations = 0;
            int sum = 0;

            while (li < ri)
            {
                sum = nums[li]+nums[ri];

                if (sum == k)
                {
                    li++;
                    ri--;
                    operations++;
                }
                else if (sum > k)
                {
                    ri--;
                }
                else
                {
                    li++;
                }
            }

            return operations;
        }

        public int MaxOperations2(int[] nums, int k)
        {
            if (nums.Length == 0) return 0;
            int operations = 0;

            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if (map.ContainsKey(k - num) && map[k - num] > 0)
                {
                    map[k - num]--;
                    operations++;
                }
                else {
                    if (!map.TryAdd(num, 1))
                    {
                        map[num]++;
                    }
                }
            }

            return operations;
        }
    }
}
