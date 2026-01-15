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
  public void SetFirstName(string firstName)
  {
    this.firstName=firstName;

  }
  public void SetLastName(string lastName){this.lastName=lastName;}
  public void SetAddress(string address) { this.address = address; }
  public void SetCity(string city) { this.city = city; }
  public void SetState(string state) { this.state = state; }
  public void SetZip(string zip) { this.zip = zip; }
  public void SetPhone(string phone) { this.phone = phone; }
  public void SetEmail(string email) { this.email = email; }
  public string GetFirstName(){return firstName;}
  public string GetLastName() { return lastName; }

  public override string ToString()
    {
        return "First Name: " + firstName +
               "\nLast Name: " + lastName +
               "\nAddress: " + address +
               "\nCity: " + city +
               "\nState: " + state +
               "\nZip: " + zip +
               "\nPhone: " + phone +
               "\nEmail: " + email;
    }
}