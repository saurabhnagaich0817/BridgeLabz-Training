using System;
class Uppercase
{
  static void Main()
  {
      Console.WriteLine("Enter text:");
      string s=Console.ReadLine();

      Console.WriteLine("Upper ASCII :"+convert(s));
      Console.WriteLine("Upper Built-in :"+s.ToLower());
  }
  static string convert(string s)
  {
    char[] a=new char[s.Length];
    for(int i = 0; i < s.Length; i++)
    {
      if(s[i] >= 'A' && s[i] <= 'Z')
      {
        a[i]=(char)(s[i]+32);
      }
      else
      {
        a[i]=s[i];
      }
    }
    return new string(a);
  }
}