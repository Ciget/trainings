using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class MaxAvgSubarrayTest
    {
        MaxAvgSubarray _engine = new MaxAvgSubarray();

        [Theory]
        [InlineData(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75)]
        [InlineData(new[] {5 }, 1, 5)]
        [InlineData(new[] { 4, 0, 4, 3, 3 }, 5, 2.8)]
        [InlineData(new[] { 0, 4, 0, 3, 2 },1, 4)]
        public void ShouldBePositive(int[] nums, int k, double result)
        {
            _engine.FindMaxAverage(nums, k).Should().Be(result);
        }
    }
}
