using System;

public class Contact
{
    private string fName;
    private string lName;
    private string cityName;
    private string stateName;

    public string GetFirstName() => fName;
    public void SetFirstName(string value) => fName = value;

    public string GetLastName() => lName;
    public void SetLastName(string value) => lName = value;

    public string GetCity() => cityName;
    public void SetCity(string value) => cityName = value;

    public string GetState() => stateName;
    public void SetState(string value) => stateName = value;

    public override string ToString()
    {
        return $"Name: {fName} {lName}\nCity: {cityName}\nState: {stateName}";
    }
}
