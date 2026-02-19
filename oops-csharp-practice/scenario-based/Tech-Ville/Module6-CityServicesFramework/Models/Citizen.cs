using System;

namespace Module6_CityServicesFramework.Models
{
    public class Citizen
    {
        // Private attributes (Encapsulation)
        private int id;
        private string name;
        private int age;

        // Static variable (shared across all objects)
        public static int TotalCitizens = 0;

        // Constructor
        public Citizen(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            TotalCitizens++;
        }

        // Public Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}");
        }

        public string GetName()
        {
            return name;
        }
    }
}
