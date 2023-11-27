namespace Algo;

//1137. N-th Tribonacci Number
public class FibonacciNumber
{
    public int Tribonacci(int n)
    {
        int val0 = 0;
        int val1 = 1;
        int val2 = 1;
        int nextVal = 0;
        if (n == 0) return 0;
        if (n <= 2) return 1;

        for (int i = 2; i < n; i++)
        {
            nextVal = val0 + val1 +val2;
            val0 = val1;
            val1 = val2;
            val2 = nextVal;
        }

        return nextVal;
    }
}