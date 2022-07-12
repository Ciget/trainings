namespace Algo.SortingArray;

public class QuickSort
{
    public int[] Sort(int[] inputArray)
    {
        InternalSort(inputArray, 0, inputArray.Length-1);
        
        return inputArray;
    }

    private void InternalSort(int[] inputArray, int left, int right)
    {
        if (left >= right) return;
        int pivotPos = Partition(inputArray, left, right);
        InternalSort(inputArray, left, pivotPos - 1);
        InternalSort(inputArray, pivotPos + 1, right);
    }
    
    private int Partition(int[] input, int left, int right)
    {
        int i = left-1;
        int j = right;
        int pivotalVal = input[right];
        while (true)
        {
            while (input[++i] < pivotalVal)
            {
            }

            while (j > 0 && input[--j] > pivotalVal)
            {
            }

            if (i >= j) break;
            else Swap(input, i, j);
        }
        
        Swap(input, i, right);
        return i;
    }

    private void Swap(int[] input, int left, int right)
    {
        (input[left], input[right]) = (input[right], input[left]);
    }
}