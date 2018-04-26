using System;
using System.Collections.Generic;

public class AmountTracker
{
    public AmountTracker(float amount)
    {
        Amount = amount;
    }

    public AmountTracker()
    { }

    public float Amount { get; protected set; }

    public void Increase(float amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException("Cannot increase by negative amount");

        Amount += amount;
    }

    public void Decrease(float amount)
    {
        if (amount < 0)
            throw new ArgumentOutOfRangeException("Cannot decrease by negative amount");

        Amount -= amount;
        if (Amount < 0)
            Amount = 0;
    }

    public override bool Equals(object obj)
    {
        var tracker = obj as AmountTracker;
        return tracker != null &&
               Amount == tracker.Amount;
    }

    public static bool operator ==(AmountTracker money1, AmountTracker money2)
    {
        return EqualityComparer<AmountTracker>.Default.Equals(money1, money2);
    }

    public static bool operator !=(AmountTracker money1, AmountTracker money2)
    {
        return !(money1 == money2);
    }

    public override int GetHashCode()
    {
        return -602769199 + Amount.GetHashCode();
    }
}
