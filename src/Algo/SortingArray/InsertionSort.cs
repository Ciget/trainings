namespace Algo.SortingArray;

public class InsertionSort
{
    public int[] Sort(int[] input)
    {
        if (input.Length <= 1) return input;

        for (int i = 1; i < input.Length; i++)
        {
            var currentValue = input[i];
            var j = i;
            
            while (j>1 && input[j-1]>currentValue)
            {
                (input[j - 1], input[j]) = (input[j], input[j-1]);
                j--;
            }
        }

        return input;
    }
}