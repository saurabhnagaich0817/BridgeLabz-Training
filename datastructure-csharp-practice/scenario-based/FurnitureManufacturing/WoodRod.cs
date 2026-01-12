public class WoodRod
{
    private int sizeInFeet;
    private int rate;

    public void SetSize(int size)
    {
        sizeInFeet = size;
    }

    public int GetSize()
    {
        return sizeInFeet;
    }

    public void SetRate(int rate)
    {
        this.rate = rate;
    }

    public int GetRate()
    {
        return rate;
    }

    public override string ToString()
    {
        return $"Rod Size: {sizeInFeet} ft | Rate: ₹{rate}";
    }
}
