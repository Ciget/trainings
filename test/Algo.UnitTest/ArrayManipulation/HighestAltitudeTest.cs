using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class HighestAltitudeTest
    {
        HighestAltitude _engine = new HighestAltitude();

        [Theory]
        [InlineData(new[] { -5, 1, 5, 0, -7 }, 1)]
        [InlineData(new[] { -4, -3, -2, -1, 4, 3, 2 },0)]
        public void ShouldBePositive(int[] gain, int result)
        {
            _engine.LargestAltitude(gain).Should().Be(result);
        }
    }
}
