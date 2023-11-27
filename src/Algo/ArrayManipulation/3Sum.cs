using System.Collections.ObjectModel;

namespace Algo.ArrayManipulation;

//15. 3Sum
//
// Time complexity: O(n^2)
// Memory complexity: O(1)
public class ThreeSum {
    public IList<IList<int>> Sum(int[] nums)
    {
        List<IList<int>> _result = new List<IList<int>>();

        Array.Sort(nums);

        if (nums.Length <= 2) return _result;
        int l, r;
        int sumToFind = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            l = i + 1;
            r = nums.Length-1;
            
            sumToFind = 0 -nums[i];
            while (l < r)
            {
                int val = nums[l] + nums[r];
                if (val > sumToFind)
                    r--;
                else if (val < sumToFind)
                    l++;
                else
                {
                    int left = nums[l];
                    int right = nums[r];
                    
                    _result.Add(new List<int>(new int[]{nums[i], left, right}));

                    while (l<r && nums[l] == left)
                    {
                        l++;
                    }
                    
                    while (r<nums.Length-2 && nums[r] == right)
                    {
                        r++;
                    }
                }
               
            }

            //skip the same elements
            while (i < nums.Length - 2 && nums[i] == nums[i+1])
            {
                i++;
            }
        }

        return _result;
    }
}