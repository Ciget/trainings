using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class ReshapedMatrix566Test
{
    private ReshapedMatrix566 _engine = new ReshapedMatrix566();

    [Fact]
    public void ShouldBeReshaped()
    {
        int[][] input = {new int[] {1, 2}, new[] {3, 4}};

        _engine.MatrixReshape(input, 1, 4)[0].Should().Equal(new []{ 1, 2, 3, 4 });
    }
    
    [Fact]
    public void ShouldBeReshaped2Rows()
    {
        int[][] input = {new int[] {1, 2}, new[] {3, 4}};

        _engine.MatrixReshape(input, 2, 2)[0].Should().Equal(new []{ 1, 2});
        _engine.MatrixReshape(input, 2, 2)[1].Should().Equal(new []{ 3, 4});
    }
}