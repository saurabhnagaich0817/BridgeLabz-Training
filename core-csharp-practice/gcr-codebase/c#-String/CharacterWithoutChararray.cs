using System;
class CharacterWithoutChararray
{
  static void Main()
  {
     Console.WriteLine("Enter string:");
      string s=Console.ReadLine();


      Console.WriteLine("Without ToCharArray:");
      find(s);
        Console.WriteLine("\nWith ToCharArray:");
        char [] ar=s.ToCharArray();
        foreach (char c in ar)
    {
      Console.WriteLine(c+"");
    }
  }
  static void find(string s)
  {
    for(int i = 0; i < s.Length; i++)
    {
      Console.WriteLine(s[i]+"");
    }
  }
  
}