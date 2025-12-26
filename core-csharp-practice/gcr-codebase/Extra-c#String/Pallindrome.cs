using System;
class Pallindrome
{
  static void Main()
  {
    Console.WriteLine("Enter a string:");
    string s=Console.ReadLine();
    string rev="";
    for(int i = s.Length - 1; i >= 0; i--)
    {
      rev+=s[i];
    }
    if(s.Equals(rev))
    {
      Console.WriteLine(s + " is a pallindrome");
    }
    else
    {
      Console.WriteLine(s + " is not a pallindrome");
    }
  }
}