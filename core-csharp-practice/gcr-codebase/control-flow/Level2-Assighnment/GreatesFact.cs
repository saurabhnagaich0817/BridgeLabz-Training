using System;

class GreatestFact
{
    static void Main()
    {
      // Read  n input from user
        Console.Write("Enter a  n: ");
        int  n = int.Parse(Console.ReadLine());
// Finding greatest factor
        int  gf = 1;
        // Looping from  n-1 to 1 to find greatest factor
        for (int i =  n - 1; i >= 1; i--)
        {
            if ( n % i == 0)
            {
                 gf = i;
                break;
            }
        }

        Console.WriteLine("Greatest Factor = " +  gf);
    }
}
