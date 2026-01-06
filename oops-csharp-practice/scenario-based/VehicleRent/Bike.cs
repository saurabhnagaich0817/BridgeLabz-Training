using System;

public sealed class TwoWheeler : Transport
{
    public TwoWheeler(int code, string company)
        : base(code, company, 300, 40) { }

    public override decimal GetRentCost(int timeValue, bool hourlyMode)
    {
        return hourlyMode ? hourlyCharge * timeValue : dailyCharge * timeValue;
    }
}
