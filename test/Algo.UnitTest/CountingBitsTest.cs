using FluentAssertions;

namespace Algo.UnitTest;

public class CountingBitsTest
{
    private CountingBits _engine = new CountingBits();

    [Fact]
    public void ShouldBePositive()
    {
        var result = _engine.CountBits(2);
        result[0].Should().Be(0);
        result[1].Should().Be(1);
        result[2].Should().Be(1);
    }
    [Fact]
    public void ShouldBePositive2()
    {
        var result = _engine.CountBits(5);
        result[0].Should().Be(0);
        result[1].Should().Be(1);
        result[2].Should().Be(1);
        result[3].Should().Be(2);
        result[4].Should().Be(1);
        result[5].Should().Be(2);
    }
}