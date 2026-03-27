using System;

class Calender
{
    static void Main()
    {
        Console.Write("enter month: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("enter year: ");
        int y = int.Parse(Console.ReadLine());

        showcal(m, y);
    }

    static string monthname(int m)
    {
        string[] mn =
        {
            "january","february","march","april","may","june",
            "july","august","september","october","november","december"
        };
        return mn[m - 1];
    }

    static bool leap(int y)
    {
        if(y % 400 == 0) return true;
        if(y % 100 == 0) return false;
        if(y % 4 == 0) return true;
        return false;
    }

    static int daysinmonth(int m, int y)
    {
        int[] d = {31,28,31,30,31,30,31,31,30,31,30,31};
        if(m == 2 && leap(y)) return 29;
        return d[m - 1];
    }

    static int firstday(int m, int y)
    {
        int d = 1;
        int y0 = y -(14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 *((14 - m) / 12) - 2;
        int d0 =(d + x +(31 * m0) / 12) % 7;
        return d0;
    }

    static void showcal(int m, int y)
    {
        Console.WriteLine("\n" + monthname(m) + " " + y);
        Console.WriteLine("sun mon tue wed thu fri sat");

        int fd = firstday(m, y);
        int td = daysinmonth(m, y);

        for(int i = 0; i < fd; i++)
        {
            Console.Write("    ");
        }

        for(int day = 1; day <= td; day++)
        {
            Console.Write("{0,3} ", day);
            if((day + fd) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
