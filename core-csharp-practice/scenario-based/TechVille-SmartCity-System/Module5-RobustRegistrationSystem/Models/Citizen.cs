using System;

namespace Module5_RobustRegistrationSystem.Models
{
    public class Citizen
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Citizen(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}
