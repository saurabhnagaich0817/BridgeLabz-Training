using System;

public sealed class InPatient : Patient
{
    private int wardNumber;
    private int stayDuration;

    public int WardNumber
    {
        get => wardNumber;
        set
        {
            if (value <= 0)
                throw new ArgumentException("Invalid ward number.");
            wardNumber = value;
        }
    }

    public int StayDuration
    {
        get => stayDuration;
        set
        {
            if (value < 0)
                throw new ArgumentException("Invalid stay duration.");
            stayDuration = value;
        }
    }

    public InPatient(string name, int age, Doctor doctor, int wardNumber, int stayDuration)
        : base(name, age, doctor)
    {
        WardNumber = wardNumber;
        StayDuration = stayDuration;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Category : In-Patient");
        Console.WriteLine($"Ward No : {WardNumber}");
        Console.WriteLine($"Days Admitted : {StayDuration}");
    }
}
