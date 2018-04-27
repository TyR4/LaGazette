using NUnit.Framework;

public class PaperTests
{

    private Paper paper;

    [SetUp]
    public void BeforeEachTest()
    {
        paper = new Paper(10);
    }

    [Test]
    public void Test_PaperHasAmount()
    {
        Assert.AreEqual(10, paper.Amount);
    }

    [Test]
    public void Test_CanUsePaper()
    {
        paper.Use(5);
        Assert.AreEqual(5, paper.Amount);
    }

    [Test]
    public void Test_CanGainPaper()
    {
        paper.Gain(5);
        Assert.AreEqual(15, paper.Amount);
    }

    [Test]
    public void Test_PaperStringDisplaysSheets()
    { 
        Assert.AreEqual("10 sheets", paper.ToString());
    }

}
