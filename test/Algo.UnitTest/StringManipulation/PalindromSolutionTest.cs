using System;
using FluentAssertions;
using Algo.StringManipulation;

namespace Algo.UnitTest.StringManipulation
{
    public class PalindromSolutionTest
    {
        PalindromSolution _engine = new PalindromSolution();

        [Theory]
        [InlineData("0P", false)]
        [InlineData(" ", true)]
        [InlineData("race a car", false)]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("a", true)]
        public void ShouldTestEmpty(string input, bool result)
        {
            _engine.IsPalindrome(input).Should().Be(result);
        }
    }
}

