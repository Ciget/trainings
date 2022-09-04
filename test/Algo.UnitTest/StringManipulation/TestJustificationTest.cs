using System;
using Algo.StringManipulation;
using Xunit;
using FluentAssertions;

namespace Algo.UnitTest.StringManipulation
{
    public class TestJustificationTest
    {
        TextJustification _engine = new TextJustification();

        [Fact]
        public void ShouldBeSplitInto3Lines()
        {
            var inputString = new[] { "This", "is", "an", "example", "of", "text", "justification." };

            _engine.FullJustify(inputString, 16).Should().Equal(new[] {
               "This    is    an",
               "example  of text",
               "justification.  "});

        }

        [Fact]
        public void ShouldBeSplitInto3Lines16Max()
        {
            var inputString = new[] { "What", "must", "be", "acknowledgment", "shall", "be" };

            _engine.FullJustify(inputString, 16).Should().Equal(new[] {
               "What   must   be",
  "acknowledgment  ",
  "shall be        "});

        }

        [Fact]
        public void ShouldBeSplitInto3Lines20Max()
        {
            var inputString = new[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };

            _engine.FullJustify(inputString, 20).Should().Equal(new[] {  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "});

        }
    }
}

