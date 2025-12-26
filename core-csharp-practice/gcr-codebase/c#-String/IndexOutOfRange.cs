using System;
class IndexOutOfRange
{
  static void Main()
  {
    string s="saurabh nagayach";
    try
    {
      Console.WriteLine(s[20]);
    }
    catch(IndexOutOfRangeException e)
    {
      Console.WriteLine("Exception Caught: " + e.Message);
    }
  }
}