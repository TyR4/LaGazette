using NUnit.Framework;

public class MoneyTests
{
    private Money money;

    [SetUp]
    public void BeforeEachTest()
    {
        money = new Money(10);
    }

    [Test]
    public void Test_CanEarnMoney()
    {
        money.Earn(100);
        Assert.AreEqual(110, money.Amount);
    }

    [Test]
    public void Test_CanSpendMoney()
    {
        money.Spend(10);
        Assert.AreEqual(0, money.Amount);
    }

    [Test]
    public void Test_MoneyStringDisplaysLivre()
    {
        Assert.AreEqual("10 LIVRE", money.ToString());
    }
}
