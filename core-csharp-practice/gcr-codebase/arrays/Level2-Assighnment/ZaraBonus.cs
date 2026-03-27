using System;

class Zarabns
{
    static void Main()
    {
        int n = 10;
        double[] slry = new double[n];
        double[] ser = new double[n];
        double[] bns = new double[n];
        double[] newslry = new double[n];

        double tb = 0, toldslry = 0, totalNewslry = 0;
// Taking input for salary and years of service
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEmployee {i + 1}");

            Console.Write("Enter slry: ");
            slry[i] = double.Parse(Console.ReadLine());
// Taking years of service input
            Console.Write("Enter Years of ser: ");
            ser[i] = double.Parse(Console.ReadLine());

            if(slry[i] <= 0 || ser[i] < 0)
            {
                Console.WriteLine("Invalid input! Enter again.");
                i--;
                continue;
            }
// Calculating bonus based on years of service
            if(ser[i] > 5)
                bns[i] = slry[i] * 0.05;
            else
                bns[i] = slry[i] * 0.02;

            newslry[i] = slry[i] + bns[i];

            tb += bns[i];
            toldslry += slry[i];
            totalNewslry += newslry[i];
        }
        // Displaying results
        Console.WriteLine("\nTotal Old slry = " + toldslry);
        Console.WriteLine("Total bns = " + tb);
        Console.WriteLine("Total New slry = " + totalNewslry);
    }
}
