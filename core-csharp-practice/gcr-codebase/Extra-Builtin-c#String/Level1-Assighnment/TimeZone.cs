using System;

class TimeZone
{
    static void Main()
    {
// Step 1: Get current UTC time
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
// Step 2: Define time zones
        TimeZoneInfo gmt = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
// Step 3: Convert and print time
        Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcTime, gmt));
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime, ist));
        Console.WriteLine("PST Time: " + TimeZoneInfo.ConvertTime(utcTime, pst));
    }
}
