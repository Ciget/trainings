namespace Algo;

//746. Min Cost Climbing Stairs
public class MinCostClimbingSteps
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int i = 0;
        return Math.Min(StepCheck(cost, i), StepCheck(cost, i+1));
    }

    private int StepCheck(int[] cost, int i)
    {
        if (i >= cost.Length) return 0;

        return Math.Min(StepCheck(cost, i+1), StepCheck(cost, i+2));
    }
}