using System;

namespace Module1_CitizenRegistration.Models
{
    public class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Income { get; set; }
        public int ResidencyYears { get; set; }

        public Citizen(string name, int age, double income, int residencyYears)
        {
            Name = name;
            Age = age;
            Income = income;
            ResidencyYears = residencyYears;
        }
    }
}
  