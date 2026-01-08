using System;

namespace EmployeeWage
{
    class EmployeeMenu
    {
        private IEmployeeWage service = new EmployeeWageImpl();

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Employee");
                Console.WriteLine("2. Check Attendance");
                Console.WriteLine("3. Daily Wage");
                Console.WriteLine("4. Part Time Wage");
                Console.WriteLine("5. Monthly Wage");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: service.AddEmployee(); break;
                    case 2: service.CheckAttendance(); break;
                    case 3: service.DailyWage(); break;
                    case 4: service.PartTimeWage(); break;
                    case 5: service.MonthlyWage(); break;
                    case 6: return;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
        }
    }
}
