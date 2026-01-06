using System;

public abstract class Transport : IRentService
{
    protected int transportCode;
    protected string companyName;
    protected decimal dailyCharge;
    protected decimal hourlyCharge;
    protected bool availableStatus;

    protected Transport(int code, string company, decimal dayCharge, decimal hourCharge)
    {
        transportCode = code;
        companyName = company;
        dailyCharge = dayCharge;
        hourlyCharge = hourCharge;
        availableStatus = true;
    }

    public int Code => transportCode;
    public string Company => companyName;
    public decimal PerDayCharge => dailyCharge;
    public decimal PerHourCharge => hourlyCharge;
    public bool IsFree => availableStatus;

    public void Book()
    {
        availableStatus = false;
    }

    public abstract decimal GetRentCost(int timeValue, bool hourlyMode);
}
