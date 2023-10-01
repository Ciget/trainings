namespace Algo.Queue;

//215. Kth Largest Element in an Array
public class KthLargestElement
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> queue = new PriorityQueue<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            queue.Enqueue(nums[i], nums[i]);

            if (queue.Count > k)
            {
                queue.Dequeue();
            }
        }

        return queue.Peek();
    }
}