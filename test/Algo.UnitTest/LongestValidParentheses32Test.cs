using FluentAssertions;

namespace Algo.UnitTest;

public class LongestValidParentheses32Test
{
    private readonly LongestValidParentheses32 _engine = new LongestValidParentheses32();

    [Fact]
    public void ShouldBe2()
    {
        _engine.LongestValidParentheses("(()").Should().Be(2);
    }
    
    [Fact]
    public void ShouldBe4()
    {
        _engine.LongestValidParentheses("))()())").Should().Be(4);
    }
    [Fact]
    public void ShouldBe6()
    {
        _engine.LongestValidParentheses("))(()())").Should().Be(6);
    }
    [Fact]
    public void ShouldBe0()
    {
        _engine.LongestValidParentheses("").Should().Be(0);
    }
}