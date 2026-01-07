// InPatient class
public class InPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords = new List<string>();
    private double roomCharges;
    private double treatmentCharges;

    public InPatient(string id, string name, int age, double room, double treatment)
        : base(id, name, age)
    {
        roomCharges = room;
        treatmentCharges = treatment;
    }

    // Bill = room charges + treatment charges
    public override double CalculateBill()
    {
        return roomCharges + treatmentCharges;
    }

    // Medical records methods
    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine($"- {record}");
        }
    }
}

// OutPatient class
public class OutPatient : Patient, IMedicalRecord
{
    private List<string> medicalRecords = new List<string>();
    private double consultationFee;

    public OutPatient(string id, string name, int age, double fee)
        : base(id, name, age)
    {
        consultationFee = fee;
    }

    // Bill = consultation fee only
    public override double CalculateBill()
    {
        return consultationFee;
    }

    // Medical records methods
    public void AddRecord(string record)
    {
        medicalRecords.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records:");
        foreach (var record in medicalRecords)
        {
            Console.WriteLine($"- {record}");
        }
    }
}
