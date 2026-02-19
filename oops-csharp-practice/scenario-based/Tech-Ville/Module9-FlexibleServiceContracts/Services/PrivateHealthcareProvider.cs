using System;
using Module9_FlexibleServiceContracts.Abstract;

namespace Module9_FlexibleServiceContracts.Services
{
    public class PrivateHealthcareProvider : CityServiceBase
    {
        public PrivateHealthcareProvider() 
            : base("Private Healthcare")
        {
        }

        public override void Cancel()
        {
            Console.WriteLine("Healthcare appointment cancelled.");
        }
    }
}
