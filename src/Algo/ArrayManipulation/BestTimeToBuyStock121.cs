namespace Algo.ArrayManipulation;

public class BestTimeToBuyStock121
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit=0;
        int minPrice = int.MaxValue;

        foreach (var t in prices)
        {
            if (t < minPrice)
            {
                minPrice = t;
            }
            else if (t - minPrice > maxProfit)
                maxProfit = t - minPrice;
        }

        return maxProfit;
    }
}