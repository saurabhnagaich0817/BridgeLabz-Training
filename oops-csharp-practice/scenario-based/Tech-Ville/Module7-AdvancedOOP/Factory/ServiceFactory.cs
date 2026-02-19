using Module7_AdvancedOOP.Models;

namespace Module7_AdvancedOOP.Factory
{
    public class ServiceFactory
    {
        // Static Factory Method
        public static Service CreateService(string type)
        {
            if (type == "health")
                return new PremiumHealthcareService();
            else if (type == "education")
                return new PremiumEducationService();
            else
                return new Service("Basic Service");
        }
    }
}
