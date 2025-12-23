using System;

class SunUZN
{
  static void Main()
  {
    double t=0.0;
    double val;
    while (true)
    {
      Console.Write("Enter a number (0 to stop)");
      val=double.Parse(Console.ReadLine());
      if (val <= 0)
      {
        break;
      }
      t+=val;

    }
    Console.WriteLine("total value is:"+t);
  }
}