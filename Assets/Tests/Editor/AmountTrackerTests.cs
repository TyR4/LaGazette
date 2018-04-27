using NUnit.Framework;
using System;

public class AmountTrackerTests
{
    protected AmountTracker tracker;

    [SetUp]
    public void BeforeEveryTest()
    {
        this.tracker = new AmountTracker(10);
    }

    [Test]
    public void Test_AmountTrackerHasAmount()
    {
        Assert.AreEqual(10, this.tracker.Amount);
    }

    [Test]
    public void Test_IncreaseAmount()
    {
        Assert.AreEqual(10, this.tracker.Amount);
        this.tracker.Increase(1);
        Assert.AreEqual(11, this.tracker.Amount);
    }

    [Test]
    public void Test_AmountTrackerCanHaveInitialAmountOf0()
    {
        AmountTracker tracker = new AmountTracker();
        Assert.AreEqual(0, tracker.Amount);
    }

    [Test]
    public void Test_DecreaseAmount()
    {
        Assert.AreEqual(tracker.Amount, 10);
        tracker.Decrease(1);
        Assert.AreEqual(9, tracker.Amount);
    }

    [Test]
    public void Test_AmountCannotBeNegative()
    {
        this.tracker.Decrease(100);
        Assert.AreEqual(0, tracker.Amount);
    }

    [Test]
    public void Test_TrackersEqualIfHaveSameAmount()
    {
        AmountTracker firstTracker = new AmountTracker(10);
        AmountTracker sameTracker = new AmountTracker(10);
        Assert.AreEqual(true, firstTracker.Equals(sameTracker));
    }

    [Test]
    public void Test_ThrowErrorOnNegativeAmountChanges()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => tracker.Increase(-10));
        Assert.Throws<ArgumentOutOfRangeException>(() => tracker.Decrease(-10));
    }

    [Test]
    public void Test_SubclassesHaveDifferentUnitsOfMeasure()
    {
        Money money = new Money();
        Paper paper = new Paper();
        Assert.AreNotEqual(money.UOM, paper.UOM);
    }

    [Test]
    public void Test_SubclassesAreNotEqual()
    {
        Money money = new Money();
        Paper paper = new Paper();
        Assert.AreEqual(false, money == paper);
    }

}
