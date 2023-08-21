using Algo.LinkedListManipulation;

namespace Algo.ArrayManipulation;

public class CanPlaceFlowersEngine
{
    //605. Can Place Flowers
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        int cnt = flowerbed.Length;
        int planted = 0;
        
        for (int i = 0; i < cnt; i++)
        {
            if (flowerbed[i] == 0 && 
                (i==0 || flowerbed[i-1] == 0) && (i+1==cnt || flowerbed[i+1] == 0))
            {
                flowerbed[i] = 1;
                planted++;
            }
        }

        return planted >= n;
    }
}