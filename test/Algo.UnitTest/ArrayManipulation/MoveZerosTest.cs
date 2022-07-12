using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class MoveZerosTest
{
    private MoveZeros _engine = new MoveZeros();

    [Fact]
    public void ShouldBeTrue()
    {
        int[] input = new[] {0, 1, 0, 3, 12};
        _engine.MoveZeroes(input);
        input.Should().Equal(new []{1, 3, 12, 0,0});
    }
}