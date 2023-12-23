namespace Algo;

public class GuessNumberGame
{
    public int guess(int num)
    {
        var number = 35;
        if (num > number) return -1;
        else if (num < number) return 1;
        else return 0;
    }

    //  374. Guess Number Higher or Lower
    public int GuessNumber(int n) {
        int min=1, max=n;
        int result;
        int tempResult = -1;
        while(min<=max)
        {
            result = min + (max-min)/2;
            tempResult = guess(result);

            if (tempResult == 0)
            {
                return result;
            }
            if (tempResult<0)
            {
                max = result - 1;
            } else
            {
                min = result+1;
            }

        }
        return -1;
    }
}