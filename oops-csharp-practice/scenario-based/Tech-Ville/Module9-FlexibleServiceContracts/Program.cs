using System;
using Module9_FlexibleServiceContracts.Services;
using Module9_FlexibleServiceContracts.Core;

namespace Module9_FlexibleServiceContracts
{
    class Program
    {
        static void Main(string[] args)
        {
            var healthcare = new PrivateHealthcareProvider();
            var transport = new PrivateTransportProvider();

            ServiceProcessor processor = new ServiceProcessor();

            processor.AddService(healthcare);
            processor.AddService(transport);

            processor.ProcessBookings("Ravi");

            Console.WriteLine(healthcare.TrackStatus());
            Console.WriteLine(transport.TrackStatus());

            healthcare.Cancel();
            transport.Cancel();

            Console.ReadKey();
        }
    }
}
