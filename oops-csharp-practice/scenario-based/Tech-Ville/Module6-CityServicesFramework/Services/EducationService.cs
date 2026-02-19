using System;
using Module6_CityServicesFramework.Models;

namespace Module6_CityServicesFramework.Services
{
    public class EducationService : Service
    {
        public EducationService() 
            : base("Education", "Education Department")
        {
        }

        public override void ProvideService()
        {
            Console.WriteLine("Education Service: Providing learning facilities.");
        }
    }
}
