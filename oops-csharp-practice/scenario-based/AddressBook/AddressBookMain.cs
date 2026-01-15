using System;
class AddressBookMain
{
  public static void Main()
  {
    Console.WriteLine("Welcome to addressbook program");
    AddressBookUtilityImpl utility =new AddressBookUtilityImpl();
    utility.AddContact();
    utility.DisplayContact();
    
  }
}