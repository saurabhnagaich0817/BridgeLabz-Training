using System;

public sealed class OutPatient : Patient
{
    private DateTime appointmentDate;

    public DateTime AppointmentDate
    {
        get => appointmentDate;
        set
        {
            if (value > DateTime.Now)
                throw new ArgumentException("Invalid appointment date.");
            appointmentDate = value;
        }
    }

    public OutPatient(string name, int age, Doctor doctor, DateTime appointmentDate)
        : base(name, age, doctor)
    {
        AppointmentDate = appointmentDate;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Category : Out-Patient");
        Console.WriteLine($"Visit Date : {AppointmentDate:dd-MM-yyyy}");
    }
}
