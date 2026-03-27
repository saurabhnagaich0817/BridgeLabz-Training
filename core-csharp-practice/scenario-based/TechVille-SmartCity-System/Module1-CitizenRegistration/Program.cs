using System;
using Module1_CitizenRegistration.Services;

namespace Module1_CitizenRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationService service = new RegistrationService();

            var citizen = service.RegisterCitizen();

            if (citizen != null)
            {
                int score = service.CalculateEligibilityScore(citizen);
                string category = service.GetServiceCategory(score);

                service.DisplayCitizen(citizen, score, category);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
