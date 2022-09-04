using System;
using Algo.Sequences;
using FluentAssertions;

namespace Algo.UnitTest.Sequences
{
    public class FibonacciTest
    {
        Fibonacci _engine = new Fibonacci();

        [Fact]
        public void ShouldCalNumber()
        {
            _engine.Fib(8).Should().Be(21);
        }
    }
}

