using System;

namespace Module7_AdvancedOOP.Models
{
    public class Service
    {
        protected string serviceName;
        protected int usageCount;

        // Static variable (class variable)
        public static int TotalServices = 0;

        public Service(string serviceName)
        {
            this.serviceName = serviceName;   // this keyword
            usageCount = 0;
            TotalServices++;
        }

        public virtual void ProvideService()
        {
            usageCount++;
            Console.WriteLine($"{serviceName} service provided. Usage: {usageCount}");
        }

        public string GetServiceName()
        {
            return serviceName;
        }
    }
}
