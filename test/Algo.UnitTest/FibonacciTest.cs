using FluentAssertions;

namespace Algo.UnitTest;

public class FibonacciTest
{
    private FibonacciNumber _engine = new FibonacciNumber();
    [Theory]
    [InlineData(4,4)]
    [InlineData(0,0)]
    public void ShouldBePositive(int n, int result)
    {
        _engine.Tribonacci(n).Should().Be(result);
    }

}