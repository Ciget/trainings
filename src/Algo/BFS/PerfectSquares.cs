using System;
namespace Algo.BFS
{
    /// <summary>
    /// Task #279
    /// </summary>
    public class PerfectSquares
    {
        Dictionary<int, int> sqrtNumber = new Dictionary<int, int>();

        protected bool CanBeDevided(int number, int count)
        {
            if (count == 1)
            {
                return sqrtNumber.ContainsValue(number);
            }

            foreach (var num in sqrtNumber)
            {
                if (CanBeDevided(number - num.Value, count - 1))
                {
                    return true;
                }
            }

            return false;
        }

        public int NumSquares(int n)
        {
            sqrtNumber.Clear();

            //prefil sqr array
            for (int i=1; i<=Math.Round(Math.Sqrt(n)); i++)
            {
                sqrtNumber.Add(i, i * i);
            }

            int count = 1;

            for (; count<=n; count++)
            {
                //TBD
                if (CanBeDevided(n, count))
                {
                    return count;
                }
            }

            return count;
        }
    }
}

