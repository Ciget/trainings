
namespace Algo.ArrayManipulation
{
    public class ContainerWithWater
    {
        public int MaxArea(int[] height)
        {
            if (height.Length == 0) return 0;

            int maxArea = 0;
            int li = 0, ri = height.Length - 1;

            while(li < ri) { 
                maxArea = Math.Max(maxArea, Math.Min(height[li], height[ri])*(ri-li));
                if (height[li] <= height[ri]) li++;
                else ri--;
            }

            return maxArea;
        }
    }
}
