using System;
namespace Algo
{
    public class Pow
    {
        public double MyPow(double x, int n)
        {
            long N = n;

            if (N < 0)
            {
                x = 1 / x;
                N = -N;
            }

            double result = 1;
            for (int i = 0; i<N; i++)
            {
                result = result * x;
            }

            return result;
        }
    }
}

