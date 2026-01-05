using System;

public sealed class Doctor
{
    private string doctorName;
    private string department;

    public string DoctorName
    {
        get => doctorName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Doctor name cannot be empty.");
            doctorName = value;
        }
    }

    public string Department
    {
        get => department;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Department cannot be empty.");
            department = value;
        }
    }

    public Doctor(string doctorName, string department)
    {
        DoctorName = doctorName;
        Department = department;
    }
}
