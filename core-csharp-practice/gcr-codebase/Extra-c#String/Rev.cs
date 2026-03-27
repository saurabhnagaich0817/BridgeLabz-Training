using System;
class Rec
{
  static void Main()
  {
    Console.WriteLine("Enter a string to reverse:");
    string s=Console.ReadLine();
    string rev=""; 
    for(int i = s.Length - 1; i >= 0; i--)
    {
      rev+=s[i];
    }
    Console.WriteLine("Reversed string: " + rev);
  }
}