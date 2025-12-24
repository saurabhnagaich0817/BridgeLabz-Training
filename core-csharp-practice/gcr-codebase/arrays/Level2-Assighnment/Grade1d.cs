using System;

class Grade1d
{
    static void Main()
    {
      // Taking number of students as input from user
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        // Arrays
        double[] phy = new double[n];
        double[] chem = new double[n];
        double[] mth = new double[n];
        double[] per = new double[n];
        char[] grade = new char[n];

        // Input marks
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter marks for Student {i + 1}");

            Console.Write("phy: ");
            phy[i] = double.Parse(Console.ReadLine());

            Console.Write("chem: ");
            chem[i] = double.Parse(Console.ReadLine());

            Console.Write("mth: ");
            mth[i] = double.Parse(Console.ReadLine());

            // Validation
            if(phy[i] < 0 || chem[i] < 0 || mth[i] < 0)
            {
                Console.WriteLine("Invalid marks! Enter positive values only.");
                i--; // repeat input for same student
                continue;
            }

            // per
            per[i] =(phy[i] + chem[i] + mth[i]) / 3;

            // Grade calculation
            if(per[i] >= 80)
                grade[i] = 'A';
            else if(per[i] >= 70)
                grade[i] = 'B';
            else if(per[i] >= 60)
                grade[i] = 'C';
            else if(per[i] >= 50)
                grade[i] = 'D';
            else if(per[i] >= 40)
                grade[i] = 'E';
            else
                grade[i] = 'R';
        }
        // Output
        Console.WriteLine("\n--- Student Result ---");
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1}: phy={phy[i]}, chem={chem[i]}, mth={mth[i]}, per={per[i]:F2}%, Grade={grade[i]}");
        }
    }
}
