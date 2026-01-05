public interface IPayable
{
    decimal TotalAmount { get; }
    bool PaymentDone { get; }

    void MakePayment();
    void ShowReceipt();
}
