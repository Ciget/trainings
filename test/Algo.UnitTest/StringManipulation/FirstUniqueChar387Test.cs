using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class FirstUniqueChar387Test
{
    private FirstUniqueChar387 _engine = new FirstUniqueChar387();

    [Fact]
    public void ShouldBe0()
    {
        var input = "leetcode";
        _engine.FirstUniqChar(input).Should().Be(0);
    }
    
    [Fact]
    public void ShouldBe2()
    {
        var input = "loveleetcode";
        _engine.FirstUniqChar(input).Should().Be(2);
    }
    
    [Fact]
    public void ShouldBeNegative()
    {
        var input = "aabb";
        _engine.FirstUniqChar(input).Should().Be(-1);
    }
}