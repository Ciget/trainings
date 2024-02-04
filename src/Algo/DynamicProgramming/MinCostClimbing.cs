namespace Algo.DynamicProgramming;

//746. Min Cost Climbing Stairs
public class MinCostClimbing
{
    public int MinCostClimbingStairs(int[] cost)
    {

        if (cost.Length < 2)
        {
            return cost[1];
        }

        int prev1 = cost[0];
        int prev2 = cost[1];

        for (int i = 2; i < cost.Length; i++)
        {
            int current = cost[i] +Math.Min(prev1, prev2);
            prev1 = prev2;
            prev2 = current;
        }

        return Math.Min(prev2, prev1);
    }

}