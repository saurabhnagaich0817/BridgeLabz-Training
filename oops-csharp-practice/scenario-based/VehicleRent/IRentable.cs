using System;

public interface IRentService
{
    decimal GetRentCost(int timeValue, bool hourlyMode);
}
