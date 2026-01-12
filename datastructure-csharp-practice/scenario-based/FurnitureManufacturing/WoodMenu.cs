using System;

public class WoodMenu
{
    private IWoodService woodService = new WoodServiceImpl();

    public void ShowMenu()
    {
        woodService.LoadRateTable();
        int option;

        do
        {
            Console.WriteLine("\n=== Furniture Manufacturing Unit ===");
            Console.WriteLine("1. Calculate Maximum Profit");
            Console.WriteLine("2. Profit With Waste Limit");
            Console.WriteLine("3. Best Cutting Suggestion");
            Console.WriteLine("4. Exit");
            Console.Write("Choose option: ");

            int.TryParse(Console.ReadLine(), out option);

            switch (option)
            {
                case 1:
                    Console.WriteLine("Profit: ₹" +
                        woodService.CalculateMaxProfit(12));
                    break;

                case 2:
                    Console.Write("Enter allowed waste: ");
                    int waste = int.Parse(Console.ReadLine());
                    Console.WriteLine("Profit: ₹" +
                        woodService.CalculateProfitWithWaste(12, waste));
                    break;

                case 3:
                    Console.Write("Enter allowed waste: ");
                    int w = int.Parse(Console.ReadLine());
                    woodService.DisplayOptimalCut(12, w);
                    break;

                case 4:
                    Console.WriteLine("Program Ended");
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        while (option != 4);
    }
}
