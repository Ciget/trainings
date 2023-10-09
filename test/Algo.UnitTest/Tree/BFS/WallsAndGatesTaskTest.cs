using System;
using FluentAssertions;
using Algo.BFS;

namespace Algo.UnitTest.BFS
{
    public class WallsAndGatesTaskTest
    {
        WallsAndGatesTask _engine = new WallsAndGatesTask();

        [Fact]
        public void ShouldMapCorrectly()
        {
            var input = new int[][] { new int[] { 2147483647, -1, 0, 2147483647 },
                new int[] {2147483647, 2147483647, 2147483647, -1 },
                new int[] {2147483647, -1, 2147483647, -1 },
                new int[] {0, -1, 2147483647, 2147483647 }
            };

            _engine.WallsAndGates(input);
            input.Should().BeEquivalentTo(new int[][] {
            new int[] {3, -1, 0, 1 },
            new int[] {2, 2, 1, -1 },
            new int[] {1, -1, 2, -1 },
            new int[] {0, -1, 3, 4 } });
        }

        [Fact]
        public void ShouldMapOnlyOneWall()
        {
            var input = new int[][] { new int[] { -1 } };

            _engine.WallsAndGates(input);
            input.Should().BeEquivalentTo(new int[][] {
            new int[] {-1} });
        }

    }
}

