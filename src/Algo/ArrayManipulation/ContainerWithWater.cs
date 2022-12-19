
namespace Algo.ArrayManipulation
{
    public class ContainerWithWater
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int li = 0;
            int ri = height.Length - 1;

            while (li < ri)
            {
                maxArea = Math.Max(maxArea, Math.Min(height[li], height[ri])*(ri-li));
                if (height[li] <= height[ri]) li++;
                else ri--;
            }

            return maxArea;
        }
    }
}
