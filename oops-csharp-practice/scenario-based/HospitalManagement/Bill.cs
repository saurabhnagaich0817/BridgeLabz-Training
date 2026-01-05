using System;

public sealed class Bill : IPayable
{
    private readonly string invoiceId;
    private readonly Patient linkedPatient;
    private readonly decimal billAmount;
    private bool paymentStatus;

    public decimal TotalAmount => billAmount;
    public bool PaymentDone => paymentStatus;

    public Bill(string invoiceId, Patient patient, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(invoiceId))
            throw new ArgumentException("Invoice ID required.");
        if (patient == null)
            throw new ArgumentNullException(nameof(patient));
        if (amount < 0)
            throw new ArgumentException("Amount must be positive.");

        this.invoiceId = invoiceId;
        linkedPatient = patient;
        billAmount = amount;
        paymentStatus = false;
    }

    public void MakePayment()
    {
        if (paymentStatus)
        {
            Console.WriteLine("Payment already completed.");
            return;
        }

        paymentStatus = true;
        Console.WriteLine($"₹{billAmount} payment successful for {linkedPatient.PatientName}");
    }

    public void ShowReceipt()
    {
        Console.WriteLine("===== BILL RECEIPT =====");
        Console.WriteLine($"Invoice ID : {invoiceId}");
        Console.WriteLine($"Patient    : {linkedPatient.PatientName}");
        Console.WriteLine($"Amount     : ₹{billAmount}");
        Console.WriteLine($"Status     : {(paymentStatus ? "PAID" : "UNPAID")}");
        Console.WriteLine("========================");
    }
}
