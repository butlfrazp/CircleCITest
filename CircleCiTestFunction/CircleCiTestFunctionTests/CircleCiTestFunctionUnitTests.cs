namespace CircleCiTestFunctionTests;

public class CircleCiTestFunctionUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ThisTestWillAlwaysSucceed()
    {
        Assert.Pass();
    }

    [Test]
    public void ThisTestWillAlwaysPass()
    {
        Assert.Pass();
    }

    [Test]
    public void FailingTest()
    {
        Assert.Fail();
    }

    [Test]
    public void FailByCrash()
    {
        throw new Exception("Uh oh....");
    }
}
