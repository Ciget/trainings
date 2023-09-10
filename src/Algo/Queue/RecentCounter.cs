namespace Algo.Queue;

public class RecentCounter
{
    private Queue<int> requests = new Queue<int>();
    private int counter = 0;
    public RecentCounter() {
        
    }
    
    public int Ping(int t) {
        requests.Enqueue(t);
        counter++;

        while (requests.Count > 0 && (requests.Peek() > t || requests.Peek() < (t - 3000)))
        {
            requests.Dequeue();
            counter--;
        }

        return counter;
    }
}