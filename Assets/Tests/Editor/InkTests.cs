using NUnit.Framework;

public class InkTests
{

    private Ink ink = new Ink(10);

    [SetUp]
    public void BeforeEachTest()
    {
        ink = new Ink(10);
    }

    [Test]
    public void Test_InkHasAmount()
    {
        Assert.AreEqual(10, ink.Amount);
    }

    [Test]
    public void Test_CanAddInk()
    {
        ink.Add(4);
        Assert.AreEqual(14, ink.Amount);
    }

    [Test]
    public void Test_CanDepleteInk()
    {
        ink.Deplete(4);
        Assert.AreEqual(6, ink.Amount);
    }

    [Test]
    public void Test_InkStringDisplaysUnits()
    {
        Assert.AreEqual("10 units", ink.ToString());
    }

}
