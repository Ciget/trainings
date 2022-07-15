namespace Algo.ArrayManipulation;

public class TwoSum167
{
    public int[] TwoSumNotSorter(int[] nums, int target)
    {
        Dictionary<int, int> _set = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (_set.ContainsKey(diff))
            {
                return new[] { _set[diff], i};
            }

            if (!_set.ContainsKey(nums[i])) _set.Add(nums[i], i);
        }

        return null;
    }
    
    public int[] TwoSum(int[] numbers, int target)
    {
        int low = 0;
        int high = numbers.Length-1;
        while (low < high)
        {
            int sum = numbers[low] + numbers[high];
            if ( sum== target)
            {
                return new[] {low + 1, high + 1};
            }
            else if (sum<target)
            {
                low++;
            }
            else
            {
                high--;
            }
        }

        return new[] {-1, -1};
    }
    
    public int[] TwoSumBruteForce(int[] numbers, int target) {
        
        for (int i =0; i<numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return new[] {i + 1, j + 1};
                }
            }
        }

        return new[] {-1, -1};
    }
}