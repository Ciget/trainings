namespace Algo;

   
//6358
//k=1
public class BiggerNumber
{
    public int FindNumber(string input, int k)
    {
        if (input.Length <= k) return 0;
        
        for (int i = 0; i < k; i++)
        {
            int tempValue = int.Parse(input.Remove(0,1 ));
            for (int j = 1; j < input.Length; j++)
            {
                int t = int.Parse(input.Remove(j, 1));
                tempValue = tempValue < t ? t : tempValue;
            }

            input = tempValue.ToString();
        }

        return int.Parse(input);
    }
}