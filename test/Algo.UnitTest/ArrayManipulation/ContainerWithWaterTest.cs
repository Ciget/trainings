using Xunit;

using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation
{
    public class ContainerWithWaterTest
    {
        ContainerWithWater _engine = new ContainerWithWater();

        [Fact]
        public void ShouldFindBiggerTank()
        {
            int[] input = new int[]{1, 8, 6, 2, 5, 4, 8, 3, 7};
            _engine.MaxArea(input).Should().Be(49);
        }

        [Fact]
        public void ShouldFindBe1()
        {
            int[] input = new int[] { 1, 1};
            _engine.MaxArea(input).Should().Be(1);
        }
    }
}
