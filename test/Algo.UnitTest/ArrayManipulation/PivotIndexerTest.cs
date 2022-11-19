using System;
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
	public class PivotIndexerTest
	{
		PivotIndexer _engine = new PivotIndexer();

		[Theory]
		[InlineData(new []{ 1, 7, 3, 6, 5, 6 }, 3)]
        [InlineData(new[] { 1, 2,3}, -1)]
        [InlineData(new[] { 2,1,-1 }, 0)]
        public void ShouldFindPivotIndex(int[] nums, int result)
		{
			_engine.PivotIndex(nums).Should().Be(result);
		}
	}
}

