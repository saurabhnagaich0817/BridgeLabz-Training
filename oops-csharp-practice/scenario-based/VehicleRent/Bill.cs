using System;

public class Invoice
{
    public static void Generate(Transport t, int timeValue, bool hourlyMode, decimal total)
    {
        Console.WriteLine("\n========== RENT INVOICE ==========");
        Console.WriteLine($"Vehicle Code : {t.Code}");
        Console.WriteLine($"Company      : {t.Company}");
        Console.WriteLine($"Charge Mode  : {(hourlyMode ? "Hourly" : "Daily")}");
        Console.WriteLine($"Duration     : {timeValue}");
        Console.WriteLine($"Amount Paid  : ₹{total}");
        Console.WriteLine("=================================\n");
    }
}
