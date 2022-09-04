using System;
using Algo.Stack;
using FluentAssertions;

namespace Algo.UnitTest.Stack
{
    public class DailyTemperatureTaskTest
    {
        DailyTemperaturesTask _engine = new DailyTemperaturesTask();

        [Fact]
        public void ShouldHandleCorrect()
        {
            var temperature = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            _engine.DailyTemperatures(temperature).Should().BeEquivalentTo(new int[] { 1, 1, 4, 2, 1, 1, 0, 0 });
        }

        [Fact]
        public void ShouldHandleCorrect2()
        {
            var temperature = new int[] { 30, 40, 50, 60 };
            _engine.DailyTemperatures(temperature).Should().BeEquivalentTo(new int[] { 1, 1, 1, 0 });
        }
    }
}

