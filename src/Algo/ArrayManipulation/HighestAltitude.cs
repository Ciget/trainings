
namespace Algo.ArrayManipulation
{
    //1732. Find the Highest Altitude
    public class HighestAltitude
    {
        public int LargestAltitude(int[] gain)
        {
            int result =0;
            int currentAlt = 0;
            for (int i = 0; i < gain.Length; i++)
            {
                currentAlt += gain[i];
                if(currentAlt>result) result = currentAlt;
            }

            return result;
        }
    }
}
