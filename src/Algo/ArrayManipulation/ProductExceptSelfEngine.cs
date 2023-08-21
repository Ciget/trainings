namespace Algo.ArrayManipulation;

public class ProductExceptSelfEngine
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answers = new int[nums.Length];
        int currentProduct = 1;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0) answers[i] = 1;
            else answers[i] = answers[i - 1] * nums[i - 1];
        }
        
        for (int i = nums.Length-1; i>=0; i--)
        {
             answers[i] = currentProduct * answers[i];
             currentProduct = currentProduct * nums[i];
        }

        return answers;
    }
}