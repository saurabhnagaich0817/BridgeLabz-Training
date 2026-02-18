using System;

namespace Module4_CitizenProfileManagement.Models
{
    public class CitizenProfile
    {
        public string Name;
        public string Email;
        public string Address;

        public CitizenProfile(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }
    }
}
