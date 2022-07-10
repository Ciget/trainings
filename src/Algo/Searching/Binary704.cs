namespace Algo.Searching;
//O (log n) complexity
public class Binary704
{
    public int Search(int[] nums, int target)
    {
        int right = nums.Length - 1, left = 0;
        while (left <= right)
        {
            var pivot = left + (right - left) / 2;
            if (nums[pivot] == target) return pivot;
            if (target < nums[pivot]) right = pivot - 1;
            else left = pivot + 1;
        }
        return -1;
    }
}