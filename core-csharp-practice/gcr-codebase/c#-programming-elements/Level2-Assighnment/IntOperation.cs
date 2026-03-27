using System;

class IntOperation
{static void Main(){
        // taking input from user
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        // performing integer operations
        int res1 = a + b * c;
        int res2 = a * b + c;
        int res3 = c + a / b;
        int res4 = a % b + c;
        // displaying results

        Console.WriteLine("The results of Int Operations are " + res1 + ", " + res2 + ", " + res3 + ", " + res4);
    }
}
