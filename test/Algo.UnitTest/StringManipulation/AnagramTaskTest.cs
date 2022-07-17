using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class AnagramTaskTest
{
    private AnagramTask _engine = new AnagramTask();

    [Fact]
    public void ShouldBeAnagram()
    {
        _engine.IsAnagram("anagram", "margana").Should().BeTrue();
    }
    
    [Fact]
    public void ShouldNotBeAnagram()
    {
        _engine.IsAnagram("sdfdfdf", "margana").Should().BeFalse();
    }
}