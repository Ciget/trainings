namespace Algo.Queue;

//2336. Smallest Number in Infinite Set
public class SmallestInfiniteSet
{
    private PriorityQueue<int, int> _queue = new PriorityQueue<int, int>(Enumerable.Range(1, 1000).Select(x=>(x,x)));
    
    public int PopSmallest()
    {
        int smallest = _queue.Dequeue();
        while (_queue.Count > 0 && _queue.Peek() == smallest)
        {
            _queue.Dequeue();
        }

        return smallest;
    }
    
    public void AddBack(int num) {
        _queue.Enqueue(num, num);
    }
}