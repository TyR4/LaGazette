using System;
using System.Collections.Generic;

public class AmountTracker
{
    public AmountTracker(float amount)
    {
        Amount = amount;
    }

    public AmountTracker()
    {
    }

    public string UOM { get; protected set; }
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
                UOM == tracker.UOM && Amount == tracker.Amount;
    }

    public static bool operator ==(AmountTracker tracker1, AmountTracker tracker2)
    {
        return EqualityComparer<AmountTracker>.Default.Equals(tracker1, tracker2);
    }

    public static bool operator !=(AmountTracker tracker1, AmountTracker tracker2)
    {
        return !(tracker1 == tracker2);
    }

    public override int GetHashCode()
    {
        return -602769199 + Amount.GetHashCode();
    }

    public override string ToString()
    {
        return Amount + " " + UOM;
    }
}
