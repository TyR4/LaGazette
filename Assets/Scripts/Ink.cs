using System;

public class Ink : AmountTracker
{
    public Ink(float amount) : base(amount)
    {
        this.UOM = "units";
    }

    public Ink()
    {
        this.UOM = "units";
    }

    public void Deplete(float amount)
    {
        Decrease(amount);
    }

    public void Add(float amount)
    {
        Increase(amount);
    }
}