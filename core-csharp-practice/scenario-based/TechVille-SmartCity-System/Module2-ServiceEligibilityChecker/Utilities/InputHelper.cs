using System;
using Module2_ServiceEligibilityChecker.Models;  

namespace Module2_ServiceEligibilityChecker.Utilities
{
    public class InputHelper
    {
        public static Citizen TakeCitizenInput()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Income: ");
            double income = Convert.ToDouble(Console.ReadLine());

            return new Citizen(name, age, income);
        }
    }
}
