using System;
using System.Collections.Generic;
using Module5_RobustRegistrationSystem.Models;
using Module5_RobustRegistrationSystem.Exceptions;

namespace Module5_RobustRegistrationSystem.Services
{
    public class RegistrationService
    {
        private List<int> registeredIds = new List<int>();

        public Citizen RegisterCitizen()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 18)
                throw new InvalidAgeException("Age must be 18 or above");

            if (registeredIds.Contains(id))
                throw new DuplicateCitizenException("Citizen already exists");

            registeredIds.Add(id);
            return new Citizen(id, name, age);
        }
    }
}
