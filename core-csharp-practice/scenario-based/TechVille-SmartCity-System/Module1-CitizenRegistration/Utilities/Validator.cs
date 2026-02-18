using System;

namespace Module1_CitizenRegistration.Utilities
{
    public class Validator
    {
        public static bool ValidateAge(int age)
        {
            return age > 0 && age <= 120;
        }

        public static bool ValidateIncome(double income)
        {
            return income >= 0;
        }

        public static bool ValidateResidency(int years)
        {
            return years >= 0;
        }
    }
}
