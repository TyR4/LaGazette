public class Paper : AmountTracker
{

    public Paper(int amount) : base(amount)
    {
    }

    public Paper()
    {
    }

    public void Use(int numberOfSheets)
    {
        Decrease(numberOfSheets);
    }

    public void Gain(int numberOfSheets)
    {
        Increase(numberOfSheets);
    }

    public override string ToString()
    {
        return Amount + " sheets";
    }
}