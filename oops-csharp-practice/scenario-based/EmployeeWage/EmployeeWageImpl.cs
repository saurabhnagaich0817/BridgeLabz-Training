using System;

namespace EmployeeWage
{
    class EmployeeWageImpl : IEmployeeWage
    {
        private const int FULL_DAY_HOURS = 8;
        private const int WORKING_DAYS = 20;

        private Employee[] employees = new Employee[100];
        private int count = 0;

        public void AddEmployee()
        {
            if (count >= 10)
            {
                Console.WriteLine("Employee limit reached");
                return;
            }

            Console.Write("Enter Employee Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Wage Per Hour: ");
            int wage = Convert.ToInt32(Console.ReadLine());

            employees[count] = new Employee(id, name, wage);
            count++;

            Console.WriteLine("Employee Added Successfully");
        }

        public void CheckAttendance()
        {
            int isPresent = new Random().Next(0, 2);
            Console.WriteLine(isPresent == 1 ? "Employee is Present" : "Employee is Absent");
        }

        public void DailyWage()
        {
            Employee? emp = GetEmployeeById();
            if (emp == null) return;

            int wage = emp.GetWagePerHour() * FULL_DAY_HOURS;
            Console.WriteLine("Daily Wage = " + wage);
        }

        public void PartTimeWage()
        {
            Employee? emp = GetEmployeeById();
            if (emp == null) return;

            Console.Write("Enter Working Hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            int wage = emp.GetWagePerHour() * hours;
            Console.WriteLine("Part Time Wage = " + wage);
        }

        public void MonthlyWage()
        {
            Employee? emp = GetEmployeeById();
            if (emp == null) return;

            Console.Write("Enter Hours Per Day: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            int wage = emp.GetWagePerHour() * hours * WORKING_DAYS;
            Console.WriteLine("Monthly Wage = " + wage);
        }

        private Employee? GetEmployeeById()
        {
            Console.Write("Enter Employee Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                if (employees[i].GetId() == id)
                    return employees[i];
            }

            Console.WriteLine("Employee Not Found");
            return null;
        }
    }
}
