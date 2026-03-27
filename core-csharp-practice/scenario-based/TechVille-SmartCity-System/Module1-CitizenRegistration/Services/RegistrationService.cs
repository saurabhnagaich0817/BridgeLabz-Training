using System;
using Module1_CitizenRegistration.Models;
using Module1_CitizenRegistration.Utilities;

namespace Module1_CitizenRegistration.Services
{
    public class RegistrationService
    {
        public Citizen RegisterCitizen()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Residency Years: ");
            int residency = Convert.ToInt32(Console.ReadLine());

            if (!Validator.ValidateAge(age) ||
                !Validator.ValidateIncome(income) ||
                !Validator.ValidateResidency(residency))
            {
                Console.WriteLine("Invalid Input!");
                return null;
            }

            return new Citizen(name, age, income, residency);
        }

        public int CalculateEligibilityScore(Citizen citizen)
        {
            int score = 0;

            if (citizen.Age >= 18)
                score += 30;

            if (citizen.Income < 300000)
                score += 30;

            if (citizen.ResidencyYears >= 5)
                score += 40;

            return score;
        }

        public string GetServiceCategory(int score)
        {
            if (score >= 80)
                return "Platinum";
            else if (score >= 60)
                return "Gold";
            else if (score >= 40)
                return "Silver";
            else
                return "Basic";
        }

        public void DisplayCitizen(Citizen citizen, int score, string category)
        {
            Console.WriteLine("\n--- Citizen Details ---");
            Console.WriteLine("Name: " + citizen.Name);
            Console.WriteLine("Age: " + citizen.Age);
            Console.WriteLine("Income: " + citizen.Income);
            Console.WriteLine("Residency Years: " + citizen.ResidencyYears);
            Console.WriteLine("Eligibility Score: " + score);
            Console.WriteLine("Service Category: " + category);
        }
    }
}
