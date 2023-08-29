
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class MaxAmountOfOperationsTest
    {
        MaxAmountOfOperations _engine = new MaxAmountOfOperations();

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, 5, 2)]
        public void ShouldBePositive(int[] nums, int k, int result)
        {
            _engine.MaxOperations(nums, k).Should().Be(result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, 5, 2)]
        public void ShouldBePositive2(int[] nums, int k, int result)
        {
            _engine.MaxOperations2(nums, k).Should().Be(result);
        }
    }
}
