using System;
class Fact
{static void Main(string[] args)
  {
      int n= 5;
      int fact= 1;
      for(int i=1;i<=n;i++)
      {
          fact*= i;
      }

      Console.WriteLine("The factorial of " + n + " is: " + fact);
  }
}