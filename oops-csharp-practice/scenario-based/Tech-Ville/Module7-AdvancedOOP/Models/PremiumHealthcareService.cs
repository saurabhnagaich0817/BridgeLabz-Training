using System;

namespace Module7_AdvancedOOP.Models
{
    public class PremiumHealthcareService : Service
    {
        public PremiumHealthcareService() 
            : base("Premium Healthcare")   // base = super
        {
        }

        public override void ProvideService()
        {
            base.ProvideService();  // calling parent method
            Console.WriteLine("Additional Premium Medical Benefits Applied.");
        }
    }
}
