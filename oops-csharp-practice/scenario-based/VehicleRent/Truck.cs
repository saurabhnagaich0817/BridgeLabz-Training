using System;

public sealed class HeavyVehicle : Transport
{
    public HeavyVehicle(int code, string company)
        : base(code, company, 2000, 300) { }

    public override decimal GetRentCost(int timeValue, bool hourlyMode)
    {
        return hourlyMode ? hourlyCharge * timeValue : dailyCharge * timeValue;
    }
}
