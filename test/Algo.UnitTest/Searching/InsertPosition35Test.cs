using Algo.Searching;
using FluentAssertions;

namespace Algo.UnitTest.Searching;

public class InsertPosition35Test
{
    private readonly InsertPosition35 _position35 = new InsertPosition35();
    
    [Fact]
    public void ShouldBe2()
    {
        int[] inputs = {1,3,5,6};
        int target = 5;
        _position35.SearchInsert(inputs, target).Should().Be(2);
    }
    [Fact]
    public void ShouldBe1()
    {
        int[] inputs = {1,3,5,6};
        int target = 2;
        _position35.SearchInsert(inputs, target).Should().Be(1);
    }
    [Fact]
    public void ShouldBe4()
    {
        int[] inputs = {1,3,5,6};
        int target = 7;
        _position35.SearchInsert(inputs, target).Should().Be(4);
    }
}