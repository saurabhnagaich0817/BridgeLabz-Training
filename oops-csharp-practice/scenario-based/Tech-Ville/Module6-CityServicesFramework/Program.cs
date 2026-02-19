using System;
using Module6_CityServicesFramework.Models;
using Module6_CityServicesFramework.Services;

namespace Module6_CityServicesFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating Objects (Instance)
            Citizen c1 = new Citizen(1, "Ravi", 25);
            Citizen c2 = new Citizen(2, "Anita", 30);

            c1.DisplayInfo();
            c2.DisplayInfo();

            Console.WriteLine("Total Citizens: " + Citizen.TotalCitizens);

            // Services
            Service health = new HealthcareService();
            Service education = new EducationService();

            health.ProvideService();
            education.ProvideService();

            Console.ReadKey();
        }
    }
}
