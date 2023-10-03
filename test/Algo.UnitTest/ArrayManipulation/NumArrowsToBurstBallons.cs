namespace Algo.UnitTest.ArrayManipulation;

//452. Minimum Number of Arrows to Burst Balloons
public class NumArrowsToBurstBallons
{
    public int FindMinArrowShots(int[][] points)
    {
        if (points.Length == 0) return 0;
        int arrows = 1;
        Array.Sort(points, (ints, ints1) => ints[1].CompareTo(ints1[1]));
        int firstEnd = points[0][1];
        for (int i = 0; i < points.Length; i++)
        {
            if (firstEnd<points[i][0])
            {
                arrows++;
                firstEnd = points[i][1];
            }
        }

        return arrows;
    }
}