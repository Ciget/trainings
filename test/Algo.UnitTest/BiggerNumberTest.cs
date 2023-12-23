namespace Algo.UnitTest;

public class BiggerNumberTest
{
    private BiggerNumber _engine = new BiggerNumber();

    [Fact]
    public void ShouldReturn6810()
    {
        _engine.FindNumber("14594196")
    }

}