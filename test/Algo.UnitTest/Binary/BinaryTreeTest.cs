using Algo.Tree;
using FluentAssertions;

namespace Algo.UnitTest.Binary;

public class BinaryTreeTest
{
    private BinaryTree _engine = new BinaryTree();
    
    [Fact]
    public void ShouldReturnBreadthFirstPath()
    {
        var b = new Node<string>("b", new Node<string>("d"), new Node<string>("e"));
        var c = new Node<string>("c", new Node<string>("f"));
        var root = new Node<string>("a", b, c);

        _engine.BreadthFirst(root).Should().Be("abcdef");
    }
    
    [Fact]
    public void ShouldReturnDepthFirstPath()
    {
        var b = new Node<string>("b", new Node<string>("d"), new Node<string>("e"));
        var c = new Node<string>("c", new Node<string>("f"));
        var root = new Node<string>("a", b, c);

        _engine.DepthFirst(root).Should().Be("abdecf");
    }
    [Fact]
    public void ShouldReturnDepthFirstPathAlternative()
    {
        var b = new Node<string>("b", new Node<string>("d"), new Node<string>("e"));
        var c = new Node<string>("c", new Node<string>("f"));
        var root = new Node<string>("a", b, c);

        _engine.DepthFirstAlternative(root).Should().Be("abdecf");
    }
}