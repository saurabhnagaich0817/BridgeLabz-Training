namespace TrafficManager.Models
{
    class Vehicle
    {
        private string vehicleNumber;
        private string driverName;

        public Vehicle(string vehicleNumber, string driverName)
        {
            this.vehicleNumber = vehicleNumber;
            this.driverName = driverName;
        }

        public override string ToString()
        {
            return $"Vehicle No: {vehicleNumber}, Driver: {driverName}";
        }
    }
}
