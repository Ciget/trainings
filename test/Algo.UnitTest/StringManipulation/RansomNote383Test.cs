using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class RansomNote383Test
{
    private RansomNote383 _engine = new RansomNote383();

    [Fact]
    public void ShouldBeTrue()
    {
        _engine.CanConstruct("aa", "aab").Should().BeTrue();
    }
    
    [Fact]
    public void ShouldBeFalse()
    {
        _engine.CanConstruct("a", "b").Should().BeFalse();
    }
}