using System;
using Module7_AdvancedOOP.Models;
using Module7_AdvancedOOP.Factory;

namespace Module7_AdvancedOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Service s1 = ServiceFactory.CreateService("health");
            Service s2 = ServiceFactory.CreateService("education");

            s1.ProvideService();
            s2.ProvideService();

            Console.WriteLine("Total Services Created: " + Service.TotalServices);

            // instanceof equivalent in C#
            if (s1 is PremiumHealthcareService)
            {
                Console.WriteLine("s1 is a Premium Healthcare Service");
            }

            Console.ReadKey();
        }
    }
}
