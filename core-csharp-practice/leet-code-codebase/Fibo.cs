using System;
class Fibo
{
  static void Main(string[] args)
  {
      int n = 10;
      int a = 0, b = 1, c;
    Console.WriteLine("Fibonacci Series:");
      for(int i =1;i<=n;i++)
      {
          Console.Write(a + " ");
          c =a+b;
          a = b;
          b = c;
      }
  }
}
