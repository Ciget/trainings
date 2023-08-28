using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation
{
    public class CompressStringTest
    {
        CompressString _engine = new CompressString();

        [Theory]
        [InlineData(new[] { 'a', 'a', 'b', 'b', 'c', 'c' }, 6)]
        [InlineData(new[] { 'a' }, 1)]
        [InlineData(new[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' }, 4)]
        public void ShouldBePositive(char[] chars, int result)
        {
            _engine.Compress(chars).Should().Be(result);
        }
    }
}
