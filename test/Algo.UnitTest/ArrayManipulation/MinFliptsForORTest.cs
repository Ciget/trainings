using System.Collections;
using Algo.ArrayManipulation;
using FluentAssertions;

namespace Algo.UnitTest.ArrayManipulation;

public class MinFliptsForORTest
{
    private MinFliptsForOR _engine = new MinFliptsForOR();
    
    [Fact]
    public void ShouldHave3Flips()
    {
        BitArray arr = new BitArray(new int[] {5});
        arr.Length.Should().Be(3);
    }
}