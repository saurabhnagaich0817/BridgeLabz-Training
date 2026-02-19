using System;
using Module6_CityServicesFramework.Models;

namespace Module6_CityServicesFramework.Services
{
    public class HealthcareService : Service
    {
        public HealthcareService() 
            : base("Healthcare", "Health Department")
        {
        }

        public override void ProvideService()
        {
            Console.WriteLine("Healthcare Service: Providing medical support.");
        }
    }
}
