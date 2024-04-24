using FluentAssertions;

namespace Algo.UnitTest;

public class IntToRomanTest
{
    private IntToRoman _engine = new IntToRoman();

    [Theory]
    [InlineData(3, "III")]
    [InlineData(58, "LVIII")]
    [InlineData(1994, "MCMXCIV")]
    public void ShouldBeTrue(int input, string output)
    {
        _engine.ConvertToRoman(input).Should().Be(output);
    }
}