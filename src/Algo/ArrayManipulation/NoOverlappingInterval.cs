namespace Algo.ArrayManipulation;

//435. Non-overlapping Intervals
public class NoOverlappingInterval
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a,b)=>a[1].CompareTo(b[1]));
        int itemsToRemove = 0;
        int currentPointer = int.MinValue;
        for (int i = 0; i < intervals.Length; i++)
        {
            int x = intervals[i][0];
            int y = intervals[i][1];

            if (x >= currentPointer)
            {
                currentPointer = y;
            }
            else
            {
                itemsToRemove++;
            }
        }

        return itemsToRemove;
    }
}
