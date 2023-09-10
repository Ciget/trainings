namespace Algo.Queue;

public class Dota2Senate
{
    //649. Dota2 Senate
    public string PredictPartyVictory(string senate)
    {
        Queue<char> senators = new Queue<char>(senate);
        int countR = senate.Count(x => x == 'R');
        int countD = senate.Length - countR;
        
        // [Positive = Radiant Favor, Negative = Dire Favor]
        int scale = 0;
        
        while (countR > 0 && countD > 0)
        {
            char sen = senators.Dequeue();

            if (sen == 'R')
            {
                if (scale >= 0)
                {
                    countD--;
                    senators.Enqueue(sen);
                }
                scale++;
            }
            else
            {
                if (scale <= 0)
                {
                    countR--;
                    senators.Enqueue(sen);
                }
                scale--;
            }
        }

        return countR == 0 ? "Dire" : "Radiant";
    }
}