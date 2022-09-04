using System;
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class DFS1Test
    {
        DFS1 _engine = new DFS1();

        [Fact]
        public void ShouldReturn1Island()
        {
            char[][] input = { new char[] { '1', '1', '1', '1', '0' } ,
            new char[]  { '1', '1', '0', '1', '0'},
            new char[] { '1', '1', '0', '0', '0'},
            new char[] { '0', '0', '0', '0', '0'}
            };

            _engine.NumIslands(input).Should().Be(1);
        }
    }
}

