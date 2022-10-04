namespace CircleCiTestFunctionTests;

public class CircleCiTestFunctionUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ThisTestWillAlwaysFail()
    {
        Assert.Fail();
    }

    [Test]
    public void ThisTestWillAlwyasPass()
    {
        Assert.Pass();
    }
}
