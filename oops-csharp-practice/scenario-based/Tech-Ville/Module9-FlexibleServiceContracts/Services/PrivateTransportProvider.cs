using System;
using Module9_FlexibleServiceContracts.Abstract;

namespace Module9_FlexibleServiceContracts.Services
{
    public class PrivateTransportProvider : CityServiceBase
    {
        public PrivateTransportProvider() 
            : base("Private Transport")
        {
        }

        public override void Cancel()
        {
            Console.WriteLine("Transport booking cancelled.");
        }
    }
}
