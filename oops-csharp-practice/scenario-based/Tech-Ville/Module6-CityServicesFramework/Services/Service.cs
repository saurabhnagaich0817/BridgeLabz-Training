using System;

namespace Module6_CityServicesFramework.Models
{
    public class Service
    {
        protected string serviceName;
        protected string department;

        // Constructor
        public Service(string serviceName, string department)
        {
            this.serviceName = serviceName;
            this.department = department;
        }

        public virtual void ProvideService()
        {
            Console.WriteLine($"Providing {serviceName} service.");
        }
    }
}
