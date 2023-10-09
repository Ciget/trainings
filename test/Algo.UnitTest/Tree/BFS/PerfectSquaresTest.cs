using System;
using Algo.BFS;
using FluentAssertions;

namespace Algo.UnitTest.BFS
{
    public class PerfectSquaresTest
    {
        PerfectSquares _engine = new PerfectSquares();

        [Fact]
        public void ShouldReturnCorrect()
        {
            _engine.NumSquares(12).Should().Be(3);
        }

        [Fact]
        public void ShouldReturnCorrect2()
        {
            _engine.NumSquares(13).Should().Be(2);
        }
    }
}

