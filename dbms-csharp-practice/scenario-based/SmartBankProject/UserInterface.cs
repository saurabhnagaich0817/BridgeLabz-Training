using System;

class UserInterface
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter customer name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter employment type: ");
            string empType = Console.ReadLine();

            Console.Write("Enter monthly income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter existing credit dues: ");
            double dues = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter credit score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of loan defaults: ");
            int defaults = Convert.ToInt32(Console.ReadLine());

            // for the  Validation
            CreditRiskProcessor.ValidateCustomerDetails(age, empType, income, dues, score, defaults);

            // Now Calculating  
            double limit = CreditRiskProcessor.CalculateCreditLimit(income, dues, score, defaults);

            Console.WriteLine( "Customer Name: " + name + " Approved Credit Limit: ₹" + limit);
        }
        catch (InvalidCreditDataException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
