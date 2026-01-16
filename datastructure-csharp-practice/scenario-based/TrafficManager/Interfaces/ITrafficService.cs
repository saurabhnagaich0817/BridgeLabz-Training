namespace TrafficManager.Interfaces
{
  interface ITrafficService
  {
    void AddVehicleToQueue();
    void EnterRoundabout();
    void ExitRoundabout();
    void DisplayRoundabout();
    void DisplayQueue();

  }
}