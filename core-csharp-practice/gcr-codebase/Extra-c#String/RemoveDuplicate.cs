using System;
class RemoveDuplicate
{
  static void Main()
  {
    Console.WriteLine("Enter the string:");
    string s=Console.ReadLine();
    string res="";
    for(int i = 0; i < s.Length; i++)
    {
      if (res.IndexOf(s[i]) == -1)
      {
        res+=s[i];
      }

    }
    Console.WriteLine("String after removing duplicates: " + res);
  }
}