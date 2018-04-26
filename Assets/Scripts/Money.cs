using System;
using System.Collections.Generic;

public class Money
{
    public double Amount { get; private set; }

    public Money(int amount)
    {
        Amount = amount;
    }

    public Money()
    {
    }

    public void Increase(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException("Cannot increase by negative amount");

        Amount += amount;
    }

    public void Decrease(int amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException("Cannot decrease by negative amount");

        Amount -= amount;
        if (Amount < 0)
            Amount = 0;
    }

    public override string ToString()
    {
        return Amount + " LIVRES";
    }

    public override bool Equals(object obj)
    {
        var money = obj as Money;
        return money != null &&
               Amount == money.Amount;
    }

    public override int GetHashCode()
    {
        return -602769199 + Amount.GetHashCode();
    }

    public static bool operator ==(Money money1, Money money2)
    {
        return EqualityComparer<Money>.Default.Equals(money1, money2);
    }

    public static bool operator !=(Money money1, Money money2)
    {
        return !(money1 == money2);
    }
}
