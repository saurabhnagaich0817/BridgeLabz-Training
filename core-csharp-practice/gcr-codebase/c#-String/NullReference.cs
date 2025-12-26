using System;
class NullReference
{
  static void Main()
  {
    string s=null;
    try
    {
      Console.WriteLine(s.Length);

    }
    catch(NullReferenceException e)
    {
      Console.WriteLine("Exception Caught: " + e.Message);
    } 

     }

}