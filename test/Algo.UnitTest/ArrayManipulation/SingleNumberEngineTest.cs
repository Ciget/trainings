using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class SingleNumberEngineTest
{
    private SingleNumberEngine _engine = new SingleNumberEngine();

    [Theory]
    [InlineData(new []{2,2,1},1)]
    [InlineData(new []{4,1,2,1,2},4)]
    [InlineData(new []{1},1)]
    public void ShouldBePositive(int [] input, int result)
    {
        _engine.SingleNumber(input).Should().Be(result);
    }
    
}