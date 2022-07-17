namespace Algo.Searching;

public class Search2dMatrix74
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int left = 0;
        int m = matrix.Length;
        
        if (m == 0) return false;
        int n = matrix[0].Length;
        int right = n*m-1;

        while (left <= right)
        {
            int pivotalIndex = left + (right - left) / 2;
            int pivotalValue = matrix[pivotalIndex / n][pivotalIndex % n];
            if (pivotalValue == target)
            {
                return true;
            }

            if (pivotalValue > target)
            {
                right=pivotalIndex-1;
            }
            else
            {
                left=pivotalIndex+1;
            }
        }

        return false;
    }
}