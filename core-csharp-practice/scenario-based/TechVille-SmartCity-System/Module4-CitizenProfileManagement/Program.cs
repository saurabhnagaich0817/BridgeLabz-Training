using System;
using Module4_CitizenProfileManagement.Models;
using Module4_CitizenProfileManagement.Services;

namespace Module4_CitizenProfileManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfileService service = new ProfileService();

            CitizenProfile[] profiles = new CitizenProfile[3];

            for (int i = 0; i < profiles.Length; i++)
            {
                Console.WriteLine($"\nCreate Profile {i + 1}");
                profiles[i] = service.CreateProfile();
            }

            Console.Write("\nEnter name to search: ");
            string search = Console.ReadLine();

            bool found = service.SearchByName(profiles, search);
            Console.WriteLine(found ? "Citizen Found" : "Citizen Not Found");

            // Pass by Value Demo
            string email = "test@gmail.com";
            service.UpdateEmail(email);
            Console.WriteLine("Outside Method Email: " + email);

            // Pass by Reference Demo
            service.UpdateProfile(profiles[0]);
            Console.WriteLine("Updated Name: " + profiles[0].Name);

            Console.ReadKey();
        }
    }
}
