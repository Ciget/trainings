using Algo.Tree;
using FluentAssertions;

namespace Algo.UnitTest.Tree;

public class TrieTest
{
    private Trie engine = new Trie();

    [Fact]
    public void ShouldBePositive()
    {
        engine.Insert("apple");
        engine.Search("apple").Should().Be(true);
    }
}