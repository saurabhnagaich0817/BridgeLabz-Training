using System;

class StoreOddEven
{
    static void Main()
    {    
      // Taking input from user
        Console.Write("Enter a no: ");
        int no = int.Parse(Console.ReadLine());
// Validating input
        if(no<=0)
        {
            Console.WriteLine("Invalid Natural no");
            return;
        }
// Creating arrays to store odd and even nos
        int[] even = new int[no / 2 + 1];
        int[] odd = new int[no / 2 + 1];
// Storing odd and even nos
        int eIndex = 0, oIndex = 0;
// Separating odd and even nos
        for(int i = 1; i <= no; i++)
        {
            if(i % 2 == 0)
                even[eIndex++] = i;
            else
                odd[oIndex++] = i;
        }
// Displaying odd and even nos
        Console.WriteLine("Odd nos:");
        for(int i = 0; i < oIndex; i++)
            Console.Write(odd[i] + " ");
        Console.WriteLine("\nEven nos:");
        for(int i = 0; i < eIndex; i++)
            Console.Write(even[i] + " ");
    }
}
