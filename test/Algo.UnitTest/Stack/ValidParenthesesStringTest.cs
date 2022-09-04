using System;
using Algo.Stack;
using FluentAssertions;

namespace Algo.UnitTest.Stack
{
    public class ValidParenthesesStringTest
    {
        ValidParenthesesString _engine = new ValidParenthesesString();


        [Theory]
        [InlineData("()")]
        [InlineData("[]{}")]
        [InlineData("((){})")]
        public void ShouldValidateCorrectCases(string val)
        {
            _engine.IsValid(val).Should().BeTrue();
        }

        [Theory]
        [InlineData("())")]
        [InlineData("]}")]

        public void ShouldInValidateInCorrectCases(string val)
        {
            _engine.IsValid(val).Should().BeFalse();
        }
    }
}

