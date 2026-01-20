using System;

public class Aadhar
{
    private long uidNumber;
    private string personName;
    private int personAge;
    private string birthDate;

    public Aadhar(long uid, string name, int age, string dob)
    {
        uidNumber = uid;
        personName = name;
        personAge = age;
        birthDate = dob;
    }

    public long GetAadharNumber()
    {
        return uidNumber;
    }
    public void SetAadharNumber(long uid)
    {
        uidNumber = uid;
    }

    public string GetName()
    {
        return personName;
    }
    public void SetName(string name)
    {
        personName = name;
    }

    public int GetAge()
    {
        return personAge;
    }
    public void SetAge(int age)
    {
        personAge = age;
    }

    public string GetDOB()
    {
        return birthDate;
    }
    public void SetDOB(string dob)
    {
        birthDate = dob;
    }

    public override string ToString()
    {
        return "Aadhar: " + uidNumber + ", Name: " + personName +", Age: " + personAge +", DOB: " + birthDate;
    }
}
