using System;

namespace Module8_CityServiceHierarchy.Models
{
    public class RoutineService : Service
    {
        public RoutineService(int id, string name)
            : base(id, name)
        {
        }

        public override void Register()
        {
            Console.WriteLine($"Routine Service {serviceName} scheduled normally.");
        }
    }
}
