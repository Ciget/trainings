using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class MergeSortedArrays88Test
{
    private MergeSortedArrays88 _engine = new MergeSortedArrays88();

    [Fact]
    public void ShouldMergeSuccessfully()
    {
        int[] input = new[] {1, 2, 3, 0, 0, 0};
        int m = 3, n = 3;
        int[] input2 = new[] {2,5,6};

        _engine.Merge(input, m, input2, n);
        input.Should().Equal(new[] { 1, 2, 2, 3, 5, 6});
    }
}