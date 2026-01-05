using System;

public abstract class Patient
{
    private string patientName;
    private int patientAge;
    private readonly Doctor consultingDoctor;

    public string PatientName
    {
        get => patientName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Patient name required.");
            patientName = value;
        }
    }

    public int PatientAge
    {
        get => patientAge;
        set
        {
            if (value <= 0 || value > 120)
                throw new ArgumentException("Invalid age.");
            patientAge = value;
        }
    }

    public Doctor ConsultingDoctor => consultingDoctor;

    protected Patient(string name, int age, Doctor doctor)
    {
        consultingDoctor = doctor ?? throw new ArgumentNullException(nameof(doctor));
        PatientName = name;
        PatientAge = age;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine("---- Patient Details ----");
        Console.WriteLine($"Name : {PatientName}");
        Console.WriteLine($"Age  : {PatientAge}");
        Console.WriteLine($"Doctor : {ConsultingDoctor.DoctorName} ({ConsultingDoctor.Department})");
    }
}
