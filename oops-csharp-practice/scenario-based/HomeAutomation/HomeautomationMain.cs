using System;

public class HomeAutomationMain
{
    public static void Main()
    {
        Device[] deviceList = new Device[3];

        deviceList[0] = BuildDevice(1, "Hall Light", "Light");
        deviceList[1] = BuildDevice(2, "Stand Fan", "Fan");
        deviceList[2] = BuildDevice(3, "Room AC", "AC");

        IDeviceController controller = new HomeAutomationService();
        HomeMenu menu = new HomeMenu();
        menu.AssignController(controller);
        menu.AssignDevices(deviceList);

        menu.DisplayMenu();
    }

    private static Device BuildDevice(int code, string title, string category)
    {
        Device device = new Device();
        device.SetDeviceCode(code);
        device.SetDeviceTitle(title);
        device.SetDeviceCategory(category);
        return device;
    }
}
