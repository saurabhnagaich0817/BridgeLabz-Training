using System;

public interface IWoodService
{
    void LoadRateTable();
    int CalculateMaxProfit(int totalLength);
    int CalculateProfitWithWaste(int totalLength, int maxWaste);
    void DisplayOptimalCut(int totalLength, int maxWaste);
}
