
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class IncreasingTripletSubsequenceTest
    {
        private IncreasingTripletSubsequence _engine = new IncreasingTripletSubsequence();

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new[] { 5, 4, 3, 2, 1 }, false)]
        public void ShouldBePositive(int[] nums, bool result)
        {
            _engine.IncreasingTriplet(nums).Should().Be(result);

        }
    }
}
