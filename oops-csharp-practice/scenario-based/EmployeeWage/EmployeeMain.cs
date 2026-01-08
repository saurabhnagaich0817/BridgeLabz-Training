namespace EmployeeWage
{
    class Employee
    {
        private int id;
        private string name;
        private int wagePerHour;

        public Employee(int id, string name, int wagePerHour)
        {
            this.id = id;
            this.name = name;
            this.wagePerHour = wagePerHour;
        }

        public int GetId() => id;
        public string GetName() => name;
        public int GetWagePerHour() => wagePerHour;
    }
}
