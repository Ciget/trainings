
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class MaxConsecutiveOnesTest
    {
        readonly MaxConsecutiveOnes _engine = new MaxConsecutiveOnes();

        [Theory]
        [InlineData(new[] { 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 0 }, 2, 6)]
        public void ShouldBePositive(int[] nums, int k, int result)
        {
            _engine.LongestOnes(nums, k).Should().Be(result);
        }
    }
}
