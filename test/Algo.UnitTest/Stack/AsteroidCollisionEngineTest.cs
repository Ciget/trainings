using Algo.Stack;
using FluentAssertions;

namespace Algo.UnitTest.Stack;

public class AsteroidCollisionEngineTest
{
    private AsteroidCollisionEngine _engine = new AsteroidCollisionEngine();

    [Theory]
    [InlineData(new[] {5, 10, -5}, new[] {5, 10})]
    [InlineData(new[] {10,2,-5}, new[] { 10})]
    [InlineData(new[] {-2,-1,1, 2}, new[] { -2,-1,1, 2})]
    public void ShouldBePositive(int[] asteroids, int[] result)
    {
        _engine.AsteroidCollision(asteroids).Should().Equal(result);
    }
}