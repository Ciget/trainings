using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class ContainsDuplicate217Test
{
    private readonly ContainsDuplicate217 _engine = new ContainsDuplicate217();

    [Fact]
    public void ShouldBeTrue()
    {
        int[] input = {1, 2, 3, 1};

        _engine.ContainsDuplicate(input).Should().BeTrue();
    }
    
    [Fact]
    public void ShouldBeFalse()
    {
        int[] input = {1,2,3,4};

        _engine.ContainsDuplicate(input).Should().BeFalse();
    }
}