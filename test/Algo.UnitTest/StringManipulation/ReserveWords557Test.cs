using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation;

public class ReserveWords557Test
{
    private ReverseWords557 _engine = new ReverseWords557();

    [Fact]
    public void ShouldReverse()
    {
        var input = "Let's take LeetCode contest";
        _engine.ReverseWords(input).Should().Be("s'teL ekat edoCteeL tsetnoc");
    }
    
    [Fact]
    public void ShouldReverse2()
    {
        var input = "God Ding";
        _engine.ReverseWords(input).Should().Be("doG gniD");
    }
    
    //151. Reverse Words in a String
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    public void ShouldReverseWordsCorrecly(string input, string result)
    {
        _engine.ReverseWords2(input).Should().Be(result);
    }
}