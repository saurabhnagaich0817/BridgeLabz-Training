using System;

public class Device
{
    private int deviceCode;
    private string deviceTitle;
    private string deviceCategory;
    private bool powerState;

    public void SetDeviceCode(int code)
    {
        deviceCode = code;
    }

    public int GetDeviceCode()
    {
        return deviceCode;
    }

    public void SetDeviceTitle(string title)
    {
        deviceTitle = title;
    }

    public string GetDeviceTitle()
    {
        return deviceTitle;
    }

    public void SetDeviceCategory(string category)
    {
        deviceCategory = category;
    }

    public string GetDeviceCategory()
    {
        return deviceCategory;
    }

    public void SetPowerState(bool state)
    {
        powerState = state;
    }

    public bool GetPowerState()
    {
        return powerState;
    }

    public override string ToString()
    {
        return $"{deviceCode,-4} {deviceTitle,-20} {deviceCategory,-10} {(powerState ? "ON" : "OFF")}";
    }
}
