using System;
using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation
{
	public class SubsequenceCheckTest
    {
        Subsequence _engine = new Subsequence();

        [Theory]
        [InlineData("", "sample", true)]
        [InlineData("abc", "sambplec", true)]
        [InlineData("abssc", "sambplec", false)]
        public void ShouldCheckForSubsequence(string s, string t, bool result)
        {
            _engine.IsSubsequence(s, t).Should().Be(result);
        }
    }
}

