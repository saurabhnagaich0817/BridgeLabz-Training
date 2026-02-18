using System;
using Module2_ServiceEligibilityChecker.Models;

namespace Module2_ServiceEligibilityChecker.Services
{
    public class EligibilityService
    {
        public string CheckEligibility(Citizen citizen)
        {
            if (citizen.Age >= 18)
            {
                if (citizen.Income < 300000)
                    return "Gold";
                else if (citizen.Income < 600000)
                    return "Silver";
                else
                    return "Basic";
            }
            else
            {
                return "Not Eligible";
            }
        }

        public void SelectServicePackage()
        {
            Console.WriteLine("\nChoose Service Package:");
            Console.WriteLine("1. Basic");
            Console.WriteLine("2. Silver");
            Console.WriteLine("3. Gold");
            Console.WriteLine("4. Platinum");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Basic Package Selected");
                    break;
                case 2:
                    Console.WriteLine("Silver Package Selected");
                    break;
                case 3:
                    Console.WriteLine("Gold Package Selected");
                    break;
                case 4:
                    Console.WriteLine("Platinum Package Selected");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
