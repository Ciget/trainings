using System.Globalization;

namespace Algo.ArrayManipulation;

public class ArrayRotation
{
    public void RotateElement(int[] nums, int k)
    {
        int start, current, next, prev, count=0;
        for (start = 0; count < nums.Length; start++)
        {
            current = start;
            prev = nums[current];
            do
            {
                next=(current + k) % nums.Length;
                int temp = nums[next];
                nums[next] = prev;
                prev = temp;
                current = next;
                count++;
            } while (start != current);
        }
    }

    public void Rotate(int[][] matrix)
    {
        int len = matrix.Length-1;

        for (int ri = 0; ri <=len; ri++)
        {
            int current = matrix[ri][ri];
            int prev = matrix[ri][len-ri];
            matrix[ri][len - ri] = current;
            current = prev;
            prev = matrix[len - ri][len - ri];
            matrix[len - ri][len - ri] = current;
            current = prev;
            prev = matrix[len - ri][ri];
            matrix[len - ri][ri] = current;
            matrix[ri][ri] = prev;
        }
    }


}
