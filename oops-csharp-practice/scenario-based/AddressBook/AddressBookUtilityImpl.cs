using System;
public class AddressBookUtilityImpl
{
  private Contact contact=new  Contact();
  public void AddContact()
  {
    Console.Write("Enter First Name: ");
        contact.SetFirstName(Console.ReadLine());

        Console.Write("Enter Last Name: ");
        contact.SetLastName(Console.ReadLine());

        Console.Write("Enter Address: ");
        contact.SetAddress(Console.ReadLine());

        Console.Write("Enter City: ");
        contact.SetCity(Console.ReadLine());

        Console.Write("Enter State: ");
        contact.SetState(Console.ReadLine());

        Console.Write("Enter Zip: ");
        contact.SetZip(Console.ReadLine());

        Console.Write("Enter Phone: ");
        contact.SetPhone(Console.ReadLine());

        Console.Write("Enter Email: ");
        contact.SetEmail(Console.ReadLine());
  }

        public void DisplayContact(){
           Console.WriteLine("\n save contact Details");
           Console.WriteLine(contact.ToString());
         }
    
  }


