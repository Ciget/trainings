using System;
using Algo.StringManipulation;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation
{
	public class IsomorphicStringTest
	{
        IsomorphicString _engine = new IsomorphicString();

        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        public void ShouldIsomorphicStringBeTrue(string s, string t, bool r)
		{
            _engine.IsIsomorphic(s, t).Should().Be(r);
		}
    }
}

