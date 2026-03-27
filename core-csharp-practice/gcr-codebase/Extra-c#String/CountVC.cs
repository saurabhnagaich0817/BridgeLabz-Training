using System;
class CountVC
{
  static void Main()
  {
        Console.WriteLine("Enter a string:");
      string s=Console.ReadLine().ToLower();
      int vow=0;
      int cons=0;
      for(int i = 0; i < s.Length; i++)
    {
      if(s[i]>'a' && s[i] <= 'z')
      {
        if("aeiou".IndexOf(s[i]) != -1)
        {
          vow++;
        }
        else
        {
          cons++;
        }
      }
    }
    Console.WriteLine("Vowels: " + vow);
    Console.WriteLine("Consonants: " + cons);

  }
}