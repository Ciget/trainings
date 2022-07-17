using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class LongestSubstringWithoutRep3Test
{
    private LongestSubstringWithoutRep3 _engine = new LongestSubstringWithoutRep3();

    [Fact]
    public void ShouldBe3()
    {
        _engine.LengthOfLongestSubstring("abcabcbb").Should().Be(3);
    }
    
    [Fact]
    public void ShouldBe1()
    {
        _engine.LengthOfLongestSubstring("bbbbb").Should().Be(1);
    }
    
    [Fact]
    public void ShouldBeThree()
    {
        _engine.LengthOfLongestSubstring("pwwkew").Should().Be(3);
    }
}