using System;

public class HomeMenu
{
    private IDeviceController controller;
    private Device[] devices;

    public void AssignController(IDeviceController service)
    {
        controller = service;
    }

    public void AssignDevices(Device[] deviceArray)
    {
        devices = deviceArray;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("\n--- Home Automation Panel ---");
        Console.WriteLine("1. Light");
        Console.WriteLine("2. Fan");
        Console.WriteLine("3. AC");
        Console.WriteLine("4. Exit");
        Console.Write("Choose device: ");

        int.TryParse(Console.ReadLine(), out int selected);

        if (selected == 4)
            return;

        Console.Write("1. Power ON  2. Power OFF : ");
        int.TryParse(Console.ReadLine(), out int command);

        bool powerOn = command == 1;

        controller.ManageDevice(devices, selected, powerOn);
    }
}
