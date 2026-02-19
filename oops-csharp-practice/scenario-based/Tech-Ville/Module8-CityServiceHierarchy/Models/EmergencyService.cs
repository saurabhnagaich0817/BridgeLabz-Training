using System;

namespace Module8_CityServiceHierarchy.Models
{
    public class EmergencyService : Service
    {
        public EmergencyService(int id, string name)
            : base(id, name)
        {
        }

        // Overriding for specialized behavior
        public override void Register()
        {
            Console.WriteLine($"Emergency Protocol Activated for {serviceName}!");
        }

        public override void CheckStatus()
        {
            Console.WriteLine($"{serviceName} is on HIGH ALERT.");
        }
    }
}
