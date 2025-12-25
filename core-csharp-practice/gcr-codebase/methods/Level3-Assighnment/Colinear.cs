using System;

class Colinear
{
    static void Main()
    {
        int x1 = 2, y1 = 4;
        int x2 = 4, y2 = 6;
        int x3 = 6, y3 = 8;
// checking colinearity using slope and area method
        bool s = checkslope(x1, y1, x2, y2, x3, y3);
        bool a = checkarea(x1, y1, x2, y2, x3, y3);
// printing the results
        Console.WriteLine("using slope method: " + s);
        Console.WriteLine("using area method: " + a);
    }

    static bool checkslope(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double ab =(double)(y2 - y1) /(x2 - x1);
        double bc =(double)(y3 - y2) /(x3 - x2);
        double ac =(double)(y3 - y1) /(x3 - x1);

        if(ab == bc && bc == ac)
        {
            return true;
        }
        return false;
    }

    static bool checkarea(int x1, int y1, int x2, int y2, int x3, int y3)
    {
        double area = 0.5 *(
            x1 *(y2 - y3) +
            x2 *(y3 - y1) +
            x3 *(y1 - y2)
        );

        if(area == 0)
        {
            return true;
        }
        return false;
    }
}
