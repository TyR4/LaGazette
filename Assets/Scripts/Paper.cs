public class Paper : AmountTracker
{

    public Paper(int amount) : base(amount)
    {
        this.UOM = "sheets";
    }

    public Paper()
    {
        this.UOM = "sheets";
    }

    public void Use(int numberOfSheets)
    {
        Decrease(numberOfSheets);
    }

    public void Gain(int numberOfSheets)
    {
        Increase(numberOfSheets);
    }
}