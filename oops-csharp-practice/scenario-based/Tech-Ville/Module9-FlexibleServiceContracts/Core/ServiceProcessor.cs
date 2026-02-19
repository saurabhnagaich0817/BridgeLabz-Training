using System.Collections.Generic;
using Module9_FlexibleServiceContracts.Interfaces;

namespace Module9_FlexibleServiceContracts.Core
{
    public class ServiceProcessor
    {
        private List<IBookable> services = new List<IBookable>();

        public void AddService(IBookable service)
        {
            services.Add(service);
        }

        public void ProcessBookings(string citizenName)
        {
            foreach (var service in services)
            {
                service.Book(citizenName);
            }
        }
    }
}
