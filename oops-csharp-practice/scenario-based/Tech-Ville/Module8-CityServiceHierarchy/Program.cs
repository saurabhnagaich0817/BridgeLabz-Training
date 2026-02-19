using System;
using Module8_CityServiceHierarchy.Models;

namespace Module8_CityServiceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Service emergency = new EmergencyService(1, "Fire Rescue");
            Service routine = new RoutineService(2, "Water Supply");

            emergency.Register();
            emergency.CheckStatus();

            routine.Register();
            routine.CheckStatus();

            // Overloading
            routine.BookService("Ravi");
            routine.BookService("Anita", 2);

            // ToString()
            Console.WriteLine(emergency.ToString());

            // Equals()
            Service anotherEmergency = new EmergencyService(1, "Fire Rescue");

            Console.WriteLine("Are services equal? " + emergency.Equals(anotherEmergency));

            Console.ReadKey();
        }
    }
}
