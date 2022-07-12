namespace Algo.SortingArray;

public class SquaresSortedArray977
{
    public int[] SortedSquares(int[] nums)
    {
        int[] resultArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            resultArray[i] = nums[i] * nums[i];
        }
        
        Array.Sort(resultArray);
        return resultArray;
    }
}