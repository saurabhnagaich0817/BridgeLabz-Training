using System;
class Uppercase
{
  static void Main()
  {
      Console.WriteLine("Enter text:");
      string s=Console.ReadLine();

      Console.WriteLine("Upper ASCII :"+convert(s));
      Console.WriteLine("Upper Built-in :"+s.ToUpper());
  }
  static string convert(string s)
  {
    char[] a=new char[s.Length];
    for(int i = 0; i < s.Length; i++)
    {
      if (s[i] >= 'a' && s[i] <= 'z')
      {
        a[i]=(char)(s[i]-32);
      }
      else
      {
        a[i]=s[i];
      }
    }
    return new string(a);
  }
}