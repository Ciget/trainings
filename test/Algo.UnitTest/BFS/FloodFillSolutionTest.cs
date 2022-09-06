using System;
using FluentAssertions;
using Algo.BFS;

namespace Algo.UnitTest.BFS
{
    public class FloodFillSolutionTest
    {
        FloodFillSolution _engine = new FloodFillSolution();

        [Fact]
        public void ShouldFillOutCorrectly()
        {
            int[][] input = new int[][] { new[] { 1, 1, 1 },
                new int[] {1, 1, 0 },
                new int[] {1, 0, 1 } };

            var result = _engine.FloodFill(input, 1, 1, 2);

            result.Should().BeEquivalentTo(new int[][] { new int[] { 2, 2, 2 },
                new int[] {2,2,0 },
                new int[] {2,0,1 } });
        }
    }
}

