namespace FunctionOne.UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetCoverage()
    {
        var sut = new FunctionOneHelper();

        sut.TestMe1(0, 100);
        sut.TestMe1(100, 100);
        sut.TestMe1(200, 100);
        sut.TestMe1(300, 100);

        sut.TestMe2(0, 100);
        sut.TestMe2(100, 100);
        sut.TestMe2(200, 100);
        sut.TestMe2(300, 100);
    }
}
