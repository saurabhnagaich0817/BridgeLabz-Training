using System;
using System.Collections.Generic;

// Abstract Patient class
public abstract class Patient
{
    private string patientId;
    private string name;
    private int age;

    // Encapsulated properties
    public string PatientId { get { return patientId; } set { patientId = value; } }
    public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age; } set { if (value > 0) age = value; } }

    public Patient(string id, string name, int age)
    {
        PatientId = id;
        Name = name;
        Age = age;
    }

    // Abstract method for billing
    public abstract double CalculateBill();

    // Concrete method to show patient details
    public void GetPatientDetails()
    {
        Console.WriteLine($"Patient ID: {PatientId}, Name: {Name}, Age: {Age}");
    }
}

// Interface for medical records
public interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}
