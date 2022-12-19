using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class ArrayRotationTest
{
    private ArrayRotation _engine = new ArrayRotation();
    
    [Fact]
    public void ShouldRatateBy3()
    {
        int[] input = {1, 2, 3, 4, 5, 6, 7};
        _engine.RotateElement(input, 3);
        input.Should().Equal(new []{5,6,7,1,2,3,4});
    }
    
    [Fact]
    public void ShouldRatateBy2()
    {
        int[] input = {-1,-100,3,99};
        _engine.RotateElement(input, 2);
        input.Should().Equal(new []{3,99,-1,-100});
    }

    [Fact]
    public void ShouldRatateImageDimension4()
    {
        int[][] input = { 
            new []{1, 2, 3}, 
            new []{4, 5, 6},
            new []{7, 8, 9}
        };
        _engine.Rotate(input);
        input[0].Should().Equal(new[] {7, 4, 1 });
    }
}