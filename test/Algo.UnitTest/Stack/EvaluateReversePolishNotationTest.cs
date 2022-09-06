using System;
using Algo.Stack;
using FluentAssertions;

namespace Algo.UnitTest.Stack
{
    public class EvaluateReversePolishNotationTest
    {
        EvaluateReversePolishNotation _engine = new EvaluateReversePolishNotation();

        [Fact]
        public void ShouldBe9()
        {
            string[] input = new string[] { "2", "1", "+", "3", "*" };
            _engine.EvalRPN(input).Should().Be(9);
        }

        [Fact]
        public void ShouldBe6()
        {
            string[] input = new string[] { "4", "13", "5", "/", "+" };
            _engine.EvalRPN(input).Should().Be(6);
        }
    }
}

