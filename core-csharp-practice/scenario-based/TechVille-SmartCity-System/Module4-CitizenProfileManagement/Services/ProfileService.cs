using System;
using Module4_CitizenProfileManagement.Models;
using Module4_CitizenProfileManagement.Utilities;

namespace Module4_CitizenProfileManagement.Services
{
    public class ProfileService
    {
        // Pass By Value
        public void UpdateEmail(string email)
        {
            email = email + ".updated";
            Console.WriteLine("Inside Method Email: " + email);
        }

        // Pass By Reference
        public void UpdateProfile(CitizenProfile profile)
        {
            profile.Name = StringUtility.FormatName(profile.Name);
        }

        // Search
        public bool SearchByName(CitizenProfile[] profiles, string name)
        {
            foreach (var p in profiles)
            {
                if (p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        // Profile Generator
        public CitizenProfile CreateProfile()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (!StringUtility.ValidateEmail(email))
            {
                Console.WriteLine("Invalid Email!");
                return null;
            }

            Console.Write("Enter Address (City,State): ");
            string address = Console.ReadLine();

            return new CitizenProfile(name, email, address);
        }
    }
}
