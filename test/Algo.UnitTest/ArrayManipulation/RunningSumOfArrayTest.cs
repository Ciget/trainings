using System;
using Xunit;
using FluentAssertions;
using Algo.ArrayManipulation;

namespace Algo.UnitTest.ArrayManipulation
{
	public class RunningSumOfArrayTest
	{
		RunningSumOfArray _engine = new RunningSumOfArray();

        [Fact]
		public void PositiveNumber()
		{
			int[] input = new []{ 1, 2, 3, 4 };

			int[] output = new int[input.Length];
			output = _engine.RunningSum(input);

            output.Should().Equal(new[] { 1, 3, 6, 10 } );
        }
	}
}

