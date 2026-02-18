using System;
using Module2_ServiceEligibilityChecker.Models;
using Module2_ServiceEligibilityChecker.Services;
using Module2_ServiceEligibilityChecker.Utilities;

namespace Module2_ServiceEligibilityChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            EligibilityService service = new EligibilityService();

            Console.Write("How many family members to register? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"\nEnter details for member {i}");

                Citizen citizen = InputHelper.TakeCitizenInput();

                if (citizen.Age <= 0)
                {
                    Console.WriteLine("Invalid Age! Skipping Member...");
                    continue;
                }

                string result = service.CheckEligibility(citizen);

                Console.WriteLine($"Eligibility Status: {result}");

                string message = result == "Not Eligible"
                    ? "Cannot select service"
                    : "Can select service";

                Console.WriteLine(message);

                if (result != "Not Eligible")
                {
                    service.SelectServicePackage();
                }
            }

            Console.WriteLine("\nAll members processed.");
            Console.ReadKey();
        }
    }
}
