using Algo.SortingArray;
using FluentAssertions;

namespace Algo.UnitTest.SortingArray;

public class InsertionSortTest
{
    private InsertionSort _engine = new InsertionSort();
    
    [Fact]
    public void ShouldSort1()
    {
        int[] input = new[] {9, 8, 5, 7, 1};
        
        var result = _engine.Sort(input);
        result.Length.Should().Be(input.Length);
        result.Should().BeEquivalentTo(new[] {1, 5, 7, 8, 9});
    }
}