
namespace Algo.ArrayManipulation
{
    public class IncreasingTripletSubsequence
    {
        //334. Increasing Triplet Subsequence
        public bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue, second = int.MaxValue;
            if (nums.Length < 3) return false;

            foreach (var t in nums)
            {
                if (t <= first)
                {
                    first = t;
                }
                else if (t <= second)
                {
                    second = t;
                }
                else return true;
            }
            return false;
        }
    }
}
