namespace Algo;

// 338. Counting Bits
public class CountingBits
{
    public int[] CountBits(int num)
    {
        int[] ans = new int [num + 1];
        for (int x = 1; x <= num; ++x)
        {
            ans[x] = ans[x & (x - 1)] + 1;
        }

        return ans;
    }
}