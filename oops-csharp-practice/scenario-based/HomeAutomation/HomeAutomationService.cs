using System;

public class HomeAutomationService : IDeviceController
{
    public void ManageDevice(Device[] deviceList, int option, bool status)
    {
        if (option < 1 || option > deviceList.Length)
        {
            Console.WriteLine("Invalid device choice");
            return;
        }

        Device device = deviceList[option - 1];
        device.SetPowerState(status);

        switch (device.GetDeviceCategory())
        {
            case "Light":
                Console.WriteLine(status
                    ? "Light switched ON with warm glow"
                    : "Light switched OFF");
                break;

            case "Fan":
                Console.WriteLine(status
                    ? "Fan running at normal speed"
                    : "Fan stopped");
                break;

            case "AC":
                Console.WriteLine(status
                    ? "AC set to 22°C cooling mode"
                    : "AC powered OFF");
                break;

            default:
                Console.WriteLine("Unsupported device");
                break;
        }
    }
}
