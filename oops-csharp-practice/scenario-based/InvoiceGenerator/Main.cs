class Main{
    static void Main(){
        Console.WriteLine("Enter work & charges");
        Console.WriteLine("Example: Logo Design - 3000 INR, Web Page - 4500 INR");

        string userInput = Console.ReadLine();

        if (BillHelper.IsInvalid(userInput))
        {
            Console.WriteLine("Input not valid!");
            return;
        }

        BillManager bill = new BillManager(userInput);

        bill.ShowBill();

        int grandTotal = bill.CalculateTotal();
        Console.WriteLine("\nTOTAL PAYABLE: ₹" + grandTotal);
    }
}
