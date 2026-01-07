class Program
{
    static void Main(string[] args)
    {
        // Create patients
        Patient p1 = new InPatient("IP001", "Alice", 30, 5000, 2000);
        Patient p2 = new OutPatient("OP001", "Bob", 25, 500);

        // Array of patients
        Patient[] patients = { p1, p2 };

        foreach (var patient in patients)
        {
            patient.GetPatientDetails();

            // Add medical records using interface
            if (patient is IMedicalRecord recordable)
            {
                recordable.AddRecord("Initial Checkup");
                recordable.AddRecord("Blood Test");
                recordable.ViewRecords();
            }

            // Polymorphic bill calculation
            Console.WriteLine($"Total Bill: {patient.CalculateBill()}\n");
        }
    }
}
