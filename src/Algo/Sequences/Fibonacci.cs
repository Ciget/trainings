using System;
namespace Algo.Sequences
{
    public class Fibonacci
    {
        public int Fib(int n)
        {
            double goldenRatio = (1 + Math.Sqrt(5)) / 2;

            return (int) Math.Round(Math.Pow(goldenRatio, n)/Math.Sqrt(5));
        }
    }
}

