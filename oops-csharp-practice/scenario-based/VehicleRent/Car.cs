using System;

public sealed class FourWheeler : Transport
{
    public FourWheeler(int code, string company)
        : base(code, company, 1000, 150) { }

    public override decimal GetRentCost(int timeValue, bool hourlyMode)
    {
        return hourlyMode ? hourlyCharge * timeValue : dailyCharge * timeValue;
    }
}
