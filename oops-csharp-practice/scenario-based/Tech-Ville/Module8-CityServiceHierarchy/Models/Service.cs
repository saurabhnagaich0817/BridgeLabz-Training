using System;

namespace Module8_CityServiceHierarchy.Models
{
    public class Service
    {
        protected int serviceId;
        protected string serviceName;

        public Service(int id, string name)
        {
            serviceId = id;
            serviceName = name;
        }

        // Common Methods
        public virtual void Register()
        {
            Console.WriteLine($"{serviceName} registered successfully.");
        }

        public virtual void Cancel()
        {
            Console.WriteLine($"{serviceName} cancelled.");
        }

        public virtual void CheckStatus()
        {
            Console.WriteLine($"{serviceName} is active.");
        }

        // Overriding Object methods
        public override string ToString()
        {
            return $"Service ID: {serviceId}, Name: {serviceName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Service other)
            {
                return this.serviceId == other.serviceId;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return serviceId.GetHashCode();
        }

        // Method Overloading
        public void BookService(string citizenName)
        {
            Console.WriteLine($"Service booked for {citizenName}");
        }

        public void BookService(string citizenName, int priorityLevel)
        {
            Console.WriteLine($"Service booked for {citizenName} with priority {priorityLevel}");
        }
    }
}
