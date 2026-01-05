using System;

public class Program
{
    public static void Main()
    {
        Doctor heartDoctor = new Doctor("Dr. Ananya Verma", "Cardiology");
        Doctor generalDoctor = new Doctor("Dr. Rohit Mehra", "General Medicine");

        Patient wardPatient = new InPatient("Rahul Sharma", 32, heartDoctor, 210, 4);
        Patient clinicPatient = new OutPatient("Neha Gupta", 26, generalDoctor, DateTime.Now);

        wardPatient.DisplayDetails();
        Console.WriteLine();
        clinicPatient.DisplayDetails();

        IPayable billOne = new Bill("INV1001", wardPatient, 18000m);
        IPayable billTwo = new Bill("INV1002", clinicPatient, 3200m);

        billOne.MakePayment();
        billTwo.MakePayment();

        Console.WriteLine();
        billOne.ShowReceipt();
        Console.WriteLine();
        billTwo.ShowReceipt();
    }
}
