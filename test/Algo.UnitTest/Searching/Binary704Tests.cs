using Algo.Searching;
using FluentAssertions;

namespace Algo.UnitTest.Searching;

public class Binary704Tests
{
    private readonly Binary704 _binarySearch = new Binary704();
    
    [Fact]
    public void ShouldBe4()
    {
        int[] inputs = {-1,0,3,5,9,12};
        int target = 9;
        _binarySearch.Search(inputs, target).Should().Be(4);
    }
    
    [Fact]
    public void ShouldBeNegative()
    {
        int[] inputs = {-1,0,3,5,9,12};
        int target = 2;
        _binarySearch.Search(inputs, target).Should().Be(-1);
    }
}