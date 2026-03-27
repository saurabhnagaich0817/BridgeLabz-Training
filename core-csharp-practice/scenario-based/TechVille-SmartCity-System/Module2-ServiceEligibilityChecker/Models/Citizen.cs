using System;

namespace Module2_ServiceEligibilityChecker.Models
{
    public class Citizen
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Income { get; set; }

        public Citizen(string name, int age, double income)
        {
            Name = name;
            Age = age;
            Income = income;
        }
    }
}
