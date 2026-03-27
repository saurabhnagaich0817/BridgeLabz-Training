using System;
class MultipleTable
{
  static void Main()
  {
    // Taking input from user
    Console.Write("Enter the number:");
     int n=int.Parse(Console.ReadLine());
     int []a=new int[10];
     for(int i = 1; i <= 10; i++)
    {
      a[i-1]=n*i;

    }
    for(int i = 1; i <=10; i++)
    {
     Console.WriteLine(n + " * " + i + " = " + a[i-1]);
    }
  }
}