using System;
using Algo.BFS;
using Algo.Tree.BFS;
using FluentAssertions;

namespace Algo.UnitTest.BFS
{
    public class FindNearestPathToZeroTest
    {
        FindNearestPathToZero _engine = new FindNearestPathToZero();

        [Fact]
        public void ShouldFindPathToOneElement()
        {
            int[][] input = new int[][]
            {
               new int[] { 0, 0, 0 },
               new int[] { 0, 1, 0 },
               new int[] { 0, 0, 0 }
            };

            _engine.UpdateMatrix(input);
            input.Should().BeEquivalentTo(new int[][]
            {
               new int[] { 0, 0, 0 },
               new int[] { 0, 1, 0 },
               new int[] { 0, 0, 0 }
            });
        }

        [Fact]
        public void ShouldFindPathToManyElements()
        {
            int[][] input = new int[][]
            {
               new int[] { 0, 0, 0 },
               new int[] { 0, 1, 0 },
               new int[] { 1, 1, 1 }
            };

            _engine.UpdateMatrix(input).Should().BeEquivalentTo(new int[][]
            {
               new int[] { 0, 0, 0 },
               new int[] { 0, 1, 0 },
               new int[] { 1, 2, 1 }
            });
        }

        [Fact]
        public void ShouldFindPathToTooManyElements()
        {
            int[][] input = new int[][]
            {
                new int[]{1, 0, 1, 1, 0, 0, 1, 0, 0, 1 },
                new int[]{0, 1, 1, 0, 1, 0, 1, 0, 1, 1 },
                new int[]{0, 0, 1, 0, 1, 0, 0, 1, 0, 0 },
                new int[]{1, 0, 1, 0, 1, 1, 1, 1, 1, 1 },
                new int[]{0, 1, 0, 1, 1, 0, 0, 0, 0, 1 },
                new int[]{0, 0, 1, 0, 1, 1, 1, 0, 1, 0 },
                new int[]{0, 1, 0, 1, 0, 1, 0, 0, 1, 1 },
                new int[]{1, 0, 0, 0, 1, 1, 1, 1, 0, 1 },
                new int[]{1, 1, 1, 1, 1, 1, 1, 0, 1, 0 },
                new int[]{1, 1, 1, 1, 0, 1, 0, 0, 1, 1 }
            };

            _engine.UpdateMatrix(input).Should().BeEquivalentTo(new int[][]
            {
                new int[]{1, 0, 1, 1, 0, 0, 1, 0, 0, 1 },
                new int[]{0, 1, 1, 0, 1, 0, 1, 0, 1, 1 },
                new int[]{0, 0, 1, 0, 1, 0, 0, 1, 0, 0 },
                new int[]{1, 0, 1, 0, 1, 1, 1, 1, 1, 1 },
                new int[]{0, 1, 0, 1, 1, 0, 0, 0, 0, 1 },
                new int[]{0, 0, 1, 0, 1, 1, 1, 0, 1, 0 },
                new int[]{0, 1, 0, 1, 0, 1, 0, 0, 1, 1 },
                new int[]{1, 0, 0, 0, 1, 2, 1, 1, 0, 1 },
                new int[]{2, 1, 1, 1, 1, 2, 1, 0, 1, 0 },
                new int[]{3, 2, 2, 1, 0, 1, 0, 0, 1, 1 }
            });
        }
    }
}

