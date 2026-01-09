using System;

public class ATMServiceImpl : IATMOperations
{
    private CurrencyNode start;

    public void SetupCurrency()
    {
        start = new CurrencyNode(500, 10);
        start.SetNext(new CurrencyNode(200, 10));
        start.GetNext()!.SetNext(new CurrencyNode(100, 10));
        start.GetNext()!.GetNext()!.SetNext(new CurrencyNode(50, 10));
        start.GetNext()!.GetNext()!.GetNext()!.SetNext(new CurrencyNode(20, 10));
        start.GetNext()!.GetNext()!.GetNext()!.GetNext()!.SetNext(new CurrencyNode(10, 10));
        start.GetNext()!.GetNext()!.GetNext()!.GetNext()!.GetNext()!.SetNext(new CurrencyNode(5, 10));
        start.GetNext()!.GetNext()!.GetNext()!.GetNext()!.GetNext()!.GetNext()!.SetNext(new CurrencyNode(2, 10));
        start.GetNext()!.GetNext()!.GetNext()!.GetNext()!.GetNext()!.GetNext()!.GetNext()!.SetNext(new CurrencyNode(1, 10));
    }

    public void WithdrawCash(int amount)
    {
        CurrencyNode temp = start;
        int balance = amount;

        Console.WriteLine("\nCash Dispensed for ₹" + amount);

        while (temp != null && balance > 0)
        {
            int required = balance / temp.GetDenomination();

            if (required > 0)
            {
                int issued = Math.Min(required, temp.GetQuantity());
                if (issued > 0)
                {
                    Console.WriteLine($"{temp.GetDenomination()} x {issued}");
                    balance -= issued * temp.GetDenomination();
                }
            }
            temp = temp.GetNext();
        }

        if (balance > 0)
            Console.WriteLine("Cannot dispense exact amount");
    }

    public void DisableFiveHundred()
    {
        if (start != null && start.GetDenomination() == 500)
        {
            start = start.GetNext();
            Console.WriteLine("₹500 notes disabled");
        }
    }
}
