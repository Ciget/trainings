using System;
using FluentAssertions;
using Xunit;
namespace Algo.UnitTest
{
    public class MyPowTest
    {
        Pow _engine = new Pow();

        [Fact]
        public void PositivePowResult()
        {
            _engine.MyPow(2, 3).Should().Be(8);
        }

        [Fact]
        public void NegativePowResult()
        {
            _engine.MyPow(2, -2).Should().Be(0.25);
        }
    }
}

