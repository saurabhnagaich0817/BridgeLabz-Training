using System;

public class Contact
{
    private string firstName;
    private string lastName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string phone;
    private string email;

    public void SetFirstName(string v) { firstName = v; }
    public void SetLastName(string v) { lastName = v; }
    public void SetAddress(string v) { address = v; }
    public void SetCity(string v) { city = v; }
    public void SetState(string v) { state = v; }
    public void SetZip(string v) { zip = v; }
    public void SetPhone(string v) { phone = v; }
    public void SetEmail(string v) { email = v; }

    public string GetFirstName() { return firstName; }
    public string GetLastName() { return lastName; }
    public string GetCity() { return city; }
    public string GetState() { return state; }

    public override bool Equals(object obj)
    {
        Contact other = obj as Contact;
        if (other == null) return false;

        return firstName == other.firstName &&
               lastName == other.lastName;
    }

    public override string ToString()
    {
        return firstName + " " + lastName +
               ", " + city + ", " + state +
               ", " + phone + ", " + email;
    }
}
