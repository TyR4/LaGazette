using NUnit.Framework;
using System;

public class MoneyTests
{

    protected Money money;

    [SetUp]
    public void BeforeEveryTest()
    {
        this.money = new Money(10);
    }

    [Test]
    public void Test_MoneyHasAmount()
    {
        Assert.AreEqual(10, this.money.Amount);
    }

    [Test]
    public void Test_IncreaseAmount()
    {
        Assert.AreEqual(10, this.money.Amount);
        this.money.Increase(1);
        Assert.AreEqual(11, this.money.Amount);
    }

    [Test]
    public void Test_MoneyCanHaveInitialAmountOf0()
    {
        Money money = new Money();
        Assert.AreEqual(0, money.Amount);
    }

    [Test]
    public void Test_DecreaseAmount()
    {
        Assert.AreEqual(money.Amount, 10);
        money.Decrease(1);
        Assert.AreEqual(9, money.Amount);
    }

    [Test]
    public void Test_AmountCannotBeNegative()
    {
        this.money.Decrease(100);
        Assert.AreEqual(0, money.Amount);
    }

    [Test]
    public void Test_MoneyStringDisplaysLivre()
    {
        Assert.AreEqual("10 LIVRES", money.ToString());
    }

    [Test]
    public void Test_MoniesEqualIfHaveSameAmount()
    {
        Money sameMoney = new Money(10);
        Assert.AreEqual(money, sameMoney);
    }

    [Test]
    public void Test_ThrowErrorOnNegativeAmountChanges()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => money.Increase(-10));
        Assert.Throws<ArgumentOutOfRangeException>(() => money.Decrease(-10));
    }
}
