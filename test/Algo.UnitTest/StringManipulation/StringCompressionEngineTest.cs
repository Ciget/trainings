using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class StringCompressionEngineTest
{
    private StringCompressionEngine _engine = new StringCompressionEngine();

    [Theory]
    [InlineData(new  []{ 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b'}, 4)]
    [InlineData(new  []{ 'a'}, 1)]
    [InlineData(new  []{ 'a','a','b','b','c','c','c'}, 6)]
    public void ShouldBeSuccessfull(char[] input, int result)
    {
        _engine.Compress(input).Should().Be(result);
    }
}