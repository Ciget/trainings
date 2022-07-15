using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class ReverseString344Test
{
    private ReverseString344 _engine = new ReverseString344();

    [Fact]
    public void ShouldReverseString()
    {
        var input = new[] {'h', 'e', 'l', 'l', 'o'};
        _engine.ReverseString(input);
        input.Should().Equal(new[] {'o', 'l', 'l', 'e', 'h'});
    }
}