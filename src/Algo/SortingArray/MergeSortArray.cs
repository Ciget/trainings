using System.Buffers;

namespace Algo.SortingArray;

public class MergeSortArray
{
    private int[] test = new int[] { };

    public int[] MergeSort(int[] input)
    {
        if (input.Length <= 1) return input;
        int leftIndex = 0;
        int rightIndex = input.Length;
        
        int middleIndex =  (int) Math.Floor((decimal)rightIndex / 2); // 7/2  = 3.5. 
        
        int[] left = new int[middleIndex];
        int[] right = new int [rightIndex - middleIndex];
        
        Array.Copy(input, left, middleIndex);
        Array.Copy(input, middleIndex, right, 0, rightIndex - middleIndex);

        var r =  Merge(MergeSort(left), MergeSort(right));
        return r;
    }
    
    private int[] Merge(int[] left, int[] right)
    {
        int i = 0, j = 0;
        int[] result = new int[left.Length + right.Length];
        
        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
            {
                result[i + j] = left[i];
                i++;
            }
            else
            {
                result[i + j] = right[j];
                j++; 
            }
        }

        while (i < left.Length)
        {
            result[i + j] = left[i];
            i++;
        }
        
        while (j < right.Length)
        {
            result[i + j] = right[j];
            j++;
        }

        return result;
    }
}