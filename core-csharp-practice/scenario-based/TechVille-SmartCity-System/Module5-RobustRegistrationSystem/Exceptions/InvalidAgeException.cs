using System;

namespace Module5_RobustRegistrationSystem.Exceptions
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }
}
