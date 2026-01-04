using System;

class MedicalRecord
{
    public static string ClinicTitle = "GreenCare Clinic";
    private static int patientCount = 0;

    public readonly int RecordNumber;
    public string FullName;
    public int PatientAge;
    public string HealthIssue;

    public MedicalRecord(int recordNo, string fullName, int age, string issue)
    {
        this.RecordNumber = recordNo;
        this.FullName = fullName;
        this.PatientAge = age;
        this.HealthIssue = issue;
        patientCount++;
    }

    public static void ShowPatientCount()
    {
        Console.WriteLine("Total Registered Patients: " + patientCount);
    }

    public void ShowDetails(object data)
    {
        if (data is MedicalRecord)
        {
            Console.WriteLine($"Name: {FullName}, Age: {PatientAge}, Issue: {HealthIssue}");
        }
    }
}

class Application
{
    static void Main()
    {
        MedicalRecord record1 = new MedicalRecord(101, "Aarav", 30, "Cold");
        record1.ShowDetails(record1);
        MedicalRecord.ShowPatientCount();
    }
}
