using System;

class Rev
{
  static void Main(string[] args)
  {
      string str ="Hello";
      string rev ="";

      for (int i =str.Length - 1; i >=0; i--)
      {
          rev +=str[i];
      }

      Console.WriteLine("rev string: "+rev);
  }
}
