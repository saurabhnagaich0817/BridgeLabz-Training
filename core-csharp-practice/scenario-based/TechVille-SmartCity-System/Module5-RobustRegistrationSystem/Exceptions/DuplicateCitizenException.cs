using System;

namespace Module5_RobustRegistrationSystem.Exceptions
{
    public class DuplicateCitizenException : Exception
    {
        public DuplicateCitizenException(string message) : base(message) { }
    }
}
