using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class ProductExceptSelfEngineTest
{
    private ProductExceptSelfEngine _engine = new ProductExceptSelfEngine();

    [Theory]
    [InlineData(new[] {1, 2, 3, 4}, new[] {24, 12, 8, 6})]
    [InlineData(new[] {-1,1,0,-3,3}, new[] {0,0,9,0,0})]
    public void ShouldBeSuccessfull(int[] nums, int[] results)
    {
        _engine.ProductExceptSelf(nums).Should().Equal(results);
    }
}