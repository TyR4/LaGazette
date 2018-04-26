using System;

public class Money : AmountTracker
{

    public Money(int amount)
    {
        Amount = amount;
    }

    public Money()
    {
    }

    public void Earn(float amount)
    {
        Increase(amount);
    }

    public void Spend(float amount)
    {
        Decrease(amount);
    }

    public override string ToString()
    {
        return Amount + " LIVRES";
    }
}
