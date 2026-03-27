using System;
class ArrayException
{
  static void Main()
  {
    int []a={1,2,3,4};
    try
    {
      Console.WriteLine(a[6]);
    }
    catch(IndexOutOfRangeException e)
    {
      Console.WriteLine("Exception Caught: " + e.Message);
    }
  }
}