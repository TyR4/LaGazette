public class Money : AmountTracker
{

    public Money(int amount) : base(amount)
    {
        this.UOM = "LIVRE";
    }

    public Money()
    {
        this.UOM = "LIVRE";
    }

    public void Earn(float amount)
    {
        Increase(amount);
    }

    public void Spend(float amount)
    {
        Decrease(amount);
    }

}
