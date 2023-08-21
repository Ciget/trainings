namespace Algo.ArrayManipulation;

public class KidsWithCandiesEngine
{
    //1431. Kids With the Greatest Number of Candies
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int candyCount = candies.Length;
        if (candyCount == 0)
            return new List<bool>();

        List<bool> result = new List<bool>(candyCount);

        int max = candies.Max();
        for (int i = 0; i < candyCount; i++)
        {
            result.Add(candies[i]+extraCandies>=max);
        }
    
        return result;
    }
}