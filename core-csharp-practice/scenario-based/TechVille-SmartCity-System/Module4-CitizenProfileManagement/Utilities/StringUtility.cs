using System;

namespace Module4_CitizenProfileManagement.Utilities
{
    public class StringUtility
    {
        // Name Formatting
        public static string FormatName(string name)
        {
            return name.Trim().ToUpper();
        }

        // Email Validation
        public static bool ValidateEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        // Address Parsing
        public static string ExtractCity(string address)
        {
            string[] parts = address.Split(',');
            return parts[0];
        }
    }
}
