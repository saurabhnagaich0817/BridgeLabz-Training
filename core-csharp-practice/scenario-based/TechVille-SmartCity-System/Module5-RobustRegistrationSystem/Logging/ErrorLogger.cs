using System;
using System.IO;

namespace Module5_RobustRegistrationSystem.Logging
{
    public class ErrorLogger
    {
        private static string filePath = "errorlog.txt";

        public static void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");
            }
        }
    }
}
