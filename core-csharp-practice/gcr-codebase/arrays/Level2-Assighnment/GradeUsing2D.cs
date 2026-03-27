using System;

class grdUsing2D
{
    static void Main()
    {
      // Enter number of students
        Console.Write("Enter students: ");
        int n = int.Parse(Console.ReadLine());
// Creating 2D array to store marks of 3 subjects for n students
        double[,] mrk = new double[n, 3];
        double[] per = new double[n];
        char[] grd = new char[n];

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}");
            for(int j = 0; j < 3; j++)
                mrk[i, j] = double.Parse(Console.ReadLine());
// 

            per[i] =(mrk[i, 0] + mrk[i, 1] + mrk[i, 2]) / 3;
// Assigning grades based on percentage
            if(per[i] >= 80) grd[i] = 'A';
            else if(per[i] >= 70) grd[i] = 'B';
            else if(per[i] >= 60) grd[i] = 'C';
            else if(per[i] >= 50) grd[i] = 'D';
            else if(per[i] >= 40) grd[i] = 'E';
            else grd[i] = 'R';
        }

        for(int i = 0; i < n; i++)
            Console.WriteLine($"% = {per[i]}, grd = {grd[i]}");
    }
}
