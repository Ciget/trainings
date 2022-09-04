using System;
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class PacificAtlanticWaterFlow417Test
    {
        PacificAtlanticWaterFlow417 _engine = new PacificAtlanticWaterFlow417();

        [Fact]
        public void ShouldFind5Points() {
            List<int> q = new List<int>(2);

            //var input = new int[][] { new int[] { 1, 2, 2, 3, 5 }, new int[] { 3, 2, 3, 4, 4 } ,
            //    new int[] { 2, 4, 5, 3, 1 }, new int[]{ 6, 7, 1, 4, 5 }, new int[]{ 5, 1, 1, 2, 4 } };

            //var result = new int[][]
            //{new int []{0,4 }, new int []{1,3 }, new int []{1,4 }, new int[] {2,2 }, new int [] {3,0 },
            //new int []{ 3,1 }, new int[] {4,0 }};
            //_engine.PacificAtlantic(input).Should().BeEquivalentTo(result);

            q.Add(10);
            q.Add(90);
            q.Add(920);
            q.Capacity.Should().Be(2);
            q.Count.Should().Be(2);
        }
    }
}

