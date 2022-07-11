using FluentAssertions;

namespace Algo.UnitTest;

public class FirstBadVersion278Test
{
    private readonly FirstBadVersion278 _badVersion = new FirstBadVersion278();
    
    [Fact(Skip = "temp")]
    public void ShouldBe4()
    {
        int n = 5, bad = 4;
        _badVersion.FirstBadVersion(n).Should().Be(bad);
    }
    
    [Fact]
    public void ShouldBe1()
    {
        int n = 1, bad = 1;
        _badVersion.FirstBadVersion(n).Should().Be(bad);
    }
}