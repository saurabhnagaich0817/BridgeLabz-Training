using System;

public class WoodServiceImpl : IWoodService
{
    private UniversalLinkedList rateList = new UniversalLinkedList();

    public void LoadRateTable()
    {
        AddRate(1, 2);
        AddRate(2, 5);
        AddRate(3, 7);
        AddRate(4, 9);
        AddRate(6, 14);
        AddRate(12, 30);
    }

    private void AddRate(int size, int rate)
    {
        WoodRod rod = new WoodRod();
        rod.SetSize(size);
        rod.SetRate(rate);

        rateList.InsertAtEnd(rod);
    }

    // Scenario 1
    public int CalculateMaxProfit(int totalLength)
    {
        if (totalLength == 0)
            return 0;

        int highestProfit = 0;
        UniversalLinkedList.Node current = rateList.GetStart();

        while (current != null)
        {
            WoodRod rod = (WoodRod)current.GetValue();

            if (rod.GetSize() <= totalLength)
            {
                int profit =
                    rod.GetRate() +
                    CalculateMaxProfit(totalLength - rod.GetSize());

                if (profit > highestProfit)
                    highestProfit = profit;
            }

            current = current.GetNext();
        }

        return highestProfit;
    }

    // Scenario 2
    public int CalculateProfitWithWaste(int totalLength, int maxWaste)
    {
        if (totalLength <= maxWaste)
            return 0;

        int bestProfit = 0;
        UniversalLinkedList.Node current = rateList.GetStart();

        while (current != null)
        {
            WoodRod rod = (WoodRod)current.GetValue();
            int leftover = totalLength - rod.GetSize();

            if (leftover >= 0 && leftover <= maxWaste)
            {
                int profit =
                    rod.GetRate() +
                    CalculateProfitWithWaste(leftover, maxWaste);

                if (profit > bestProfit)
                    bestProfit = profit;
            }

            current = current.GetNext();
        }

        return bestProfit;
    }

    // Scenario 3
    public void DisplayOptimalCut(int totalLength, int maxWaste)
    {
        int maxProfit = 0;
        int minimumWaste = totalLength;

        UniversalLinkedList.Node current = rateList.GetStart();

        while (current != null)
        {
            WoodRod rod = (WoodRod)current.GetValue();
            int remainingLength = totalLength - rod.GetSize();

            if (remainingLength >= 0)
            {
                int profit =
                    rod.GetRate() +
                    CalculateProfitWithWaste(remainingLength, maxWaste);

                if (profit > maxProfit ||
                   (profit == maxProfit && remainingLength < minimumWaste))
                {
                    maxProfit = profit;
                    minimumWaste = remainingLength;
                }
            }

            current = current.GetNext();
        }

        Console.WriteLine($"Maximum Profit: ₹{maxProfit}");
        Console.WriteLine($"Unused Wood: {minimumWaste} ft");
    }
}
