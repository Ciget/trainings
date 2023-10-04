namespace Algo.ArrayManipulation;

//136. Single Number
public class SingleNumberEngine
{
    public int SingleNumber(int[] nums)
    {
        HashSet<int> _set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (_set.Contains(nums[i]))
            {
                _set.Remove(nums[i]);
            }
            else _set.Add(nums[i]);
        }

        return _set.First();
    }
}