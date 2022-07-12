using System.Globalization;

namespace Algo.ArrayManipulation;

public class ArrayRotation
{
    public void Rotate(int[] nums, int k)
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
}
