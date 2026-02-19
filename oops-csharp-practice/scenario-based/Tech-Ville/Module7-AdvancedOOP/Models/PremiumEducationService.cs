using System;

namespace Module7_AdvancedOOP.Models
{
    public class PremiumEducationService : Service
    {
        public PremiumEducationService() 
            : base("Premium Education")
        {
        }

        public override void ProvideService()
        {
            base.ProvideService();
            Console.WriteLine("Premium Learning Resources Activated.");
        }
    }
}
