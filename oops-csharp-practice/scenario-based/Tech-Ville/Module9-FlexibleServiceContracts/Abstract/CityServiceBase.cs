using System;
using Module9_FlexibleServiceContracts.Interfaces;

namespace Module9_FlexibleServiceContracts.Abstract
{
    public abstract class CityServiceBase : IBookable, ICancellable, ITrackable
    {
        // Encapsulation (data hiding)
        private string serviceName;
        protected int bookingCount;

        public CityServiceBase(string serviceName)
        {
            this.serviceName = serviceName;
            bookingCount = 0;
        }

        // Partial Implementation
        public virtual void Book(string citizenName)
        {
            bookingCount++;
            Console.WriteLine($"{serviceName} booked for {citizenName}");
        }

        public abstract void Cancel(); // Force child class

        public virtual string TrackStatus()
        {
            return $"{serviceName} total bookings: {bookingCount}";
        }

        protected string GetServiceName()
        {
            return serviceName;
        }
    }
}
