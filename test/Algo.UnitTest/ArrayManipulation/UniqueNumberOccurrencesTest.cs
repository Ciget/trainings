using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class UniqueNumberOccurrencesTest
{
    private UniqueNumberOccurrences _engine = new UniqueNumberOccurrences();

    [Theory]
    [InlineData(new[] {1, 2, 2, 1, 1, 3}, true)]
    [InlineData(new[] {1, 2}, false)]
    [InlineData(new[] {-3,0,1,-3,1,1,1,-3,10,0}, true)]
    public void ShouldBePositive(int[] arr, bool result)
    {
        _engine.UniqueOccurrences(arr).Should().Be(result);
    }
}