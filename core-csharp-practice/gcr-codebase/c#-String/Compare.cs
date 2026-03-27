using System;
class Compare
{
  static void Main()
  {
    Console.WriteLine("Enter two strings:");
    string s1=Console.ReadLine();
    string s2=Console.ReadLine();
    Console.WriteLine("compare String:"+find(s1,s2));
    Console.WriteLine("Comparing string using Buit-in method:"+s1.Equals(s2));


  }
  static bool find(string s1,string s2)
  {
    if (s1.Length != s2.Length)
    {
      return false;
    }
    for(int i = 0; i < s1.Length; i++)
    {
      if (s1[i] != s2[i])
      {
        return false;
      }
    }
    return true;
  }
}